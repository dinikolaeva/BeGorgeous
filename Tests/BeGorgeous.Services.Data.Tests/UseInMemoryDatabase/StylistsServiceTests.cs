namespace BeGorgeous.Services.Data.Tests.UseInMemoryDatabase
{
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Data.Stylists;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class StylistsServiceTests : BaseServiceTests
    {
        // TODO: Task<IEnumerable<T>> GetAllAsync<T>();

        // TODO: Task<IEnumerable<T>> GetByIdAsync<T>(int salonId);

        private IStylistsService Service => this.ServiceProvider.GetRequiredService<IStylistsService>();

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            await this.CreateStylistAsync();

            var name = new NLipsum.Core.Word().ToString();

            await this.Service.AddAsync(name, 1, 5, new NLipsum.Core.Sentence().ToString(), new NLipsum.Core.Word().ToString());

            var stylistsCount = await this.DbContext.Stylists.CountAsync();

            Assert.Equal(2, stylistsCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var stylist = await this.CreateStylistAsync();

            await this.Service.DeleteAsync(stylist.Id);

            var stylistsCount = this.DbContext.Stylists
                                              .Where(x => !x.IsDeleted)
                                              .ToArray()
                                              .Count();

            var deletedStylist = await this.DbContext.Stylists
                                                     .FirstOrDefaultAsync(x => x.Id == stylist.Id);

            Assert.Equal(0, stylistsCount);
            Assert.Null(deletedStylist);
        }

        [Fact]
        public async Task GetStylistsCountAsyncWorkCorrectly()
        {
            await this.CreateStylistAsync();
            await this.CreateStylistAsync();

            var expect = this.DbContext.Stylists.ToList().Count();
            var actual = await this.Service.GetStylistsCountAsync();

            Assert.Equal(expect, actual);
        }

        private async Task<Stylist> CreateStylistAsync()
        {
            var stylist = new Stylist
            {
                FullName = new NLipsum.Core.Word().ToString(),
                ShortAutobiography = new NLipsum.Core.Sentence().ToString(),
                SalonId = 1,
                CategoryId = 1,
                ImageUrl = new NLipsum.Core.Word().ToString(),
            };

            await this.DbContext.Stylists.AddAsync(stylist);

            await this.DbContext.SaveChangesAsync();

            this.DbContext.Entry<Stylist>(stylist).State = EntityState.Detached;

            return stylist;
        }
    }
}
