namespace BeGorgeous.Services.Data.Tests.UseInMemoryDatabase
{
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Data.Salons;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class SalonsServiceTests : BaseServiceTests
    {
        // TODO: Task<IEnumerable<T>> GetAllAsync<T>();

        // TODO: Task<T> GetByIdAsync<T>(int id);

        private ISalonsService Service => this.ServiceProvider.GetRequiredService<ISalonsService>();

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            await this.CreateSalonAsync();

            var name = new NLipsum.Core.Sentence().ToString();
            var cityId = 1;
            var countryId = 1;
            var streetAddress = new NLipsum.Core.Sentence().ToString();
            var imageUrl = new NLipsum.Core.Word().ToString();
            var phoneNumber = "123456789";
            var sreetMapUrl = new NLipsum.Core.Word().ToString();
            var description = new NLipsum.Core.Sentence().ToString();

            await this.Service.AddAsync(name, countryId, cityId, description, streetAddress, imageUrl, phoneNumber, sreetMapUrl);

            var salonsCount = await this.DbContext.Salons.CountAsync();

            Assert.Equal(2, salonsCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var salon = await this.CreateSalonAsync();

            await this.Service.DeleteAsync(salon.Id);

            var salonsCount = this.DbContext.Salons
                                            .Where(x => !x.IsDeleted)
                                            .ToArray()
                                            .Count();

            var deletedSalon = await this.DbContext.Salons
                                                   .FirstOrDefaultAsync(x => x.Id == salon.Id);

            Assert.Equal(0, salonsCount);
            Assert.Null(deletedSalon);
        }

        [Fact]
        public async Task RateSalonAsyncShouldGiveCorrectRating()
        {
            var salon = await this.CreateSalonAsync();

            var rateValue = 4;

            await this.Service.RateSalonAsync(1, rateValue);

            var expected = rateValue;
            var actual = salon.Rating;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task GetSalonsCountAsyncWorkCorrectly()
        {
            await this.CreateSalonAsync();
            await this.CreateSalonAsync();

            var expect = this.DbContext.Salons.ToList().Count();
            var actual = await this.Service.GetSalonsCountAsync();

            Assert.Equal(expect, actual);
        }

        private async Task<Salon> CreateSalonAsync()
        {
            var salon = new Salon
            {
                Name = new NLipsum.Core.Sentence().ToString(),
                CityId = 1,
                CountryId = 1,
                StreetAddress = new NLipsum.Core.Sentence().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
                PhoneNumber = "123456789",
                StreetMapUrl = new NLipsum.Core.Word().ToString(),
                Description = new NLipsum.Core.Sentence().ToString(),
                Rating = 4,
                RatersCount = 1,
            };

            await this.DbContext.Salons.AddAsync(salon);

            await this.DbContext.SaveChangesAsync();

            this.DbContext.Entry<Salon>(salon).State = EntityState.Detached;

            return salon;
        }
    }
}
