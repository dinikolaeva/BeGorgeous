namespace BeGorgeous.Services.Data.Tests.UseInMemoryDatabase
{
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Data.Countries;
    using BeGorgeous.Web.ViewModels.Countries;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class CountriesServiceTests : BaseServiceTests
    {
        private ICountriesService Service => this.ServiceProvider.GetRequiredService<ICountriesService>();

        [Fact]
        public async Task GetAllAsyncCountriesWorkCorrectly()
        {
            AutoMapperConfig.RegisterMappings(typeof(CountryViewModel).Assembly, typeof(Country).Assembly);

            await this.Service.AddAsync("France");
            await this.Service.AddAsync("Germany");

            var expect = this.DbContext.Countries;
            var countries = await this.Service.GetAllAsync<CountryViewModel>();

            Assert.Equal(expect.Count(), countries.Count());
        }

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            await this.CreateCountryAsync();

            var name = new NLipsum.Core.Word().ToString();

            await this.Service.AddAsync(name);

            var countriesCount = await this.DbContext.Countries.CountAsync();

            Assert.Equal(2, countriesCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var country = await this.CreateCountryAsync();

            await this.Service.DeleteAsync(country.Id);

            var countriesCount = this.DbContext.Countries
                                               .Where(x => !x.IsDeleted)
                                               .ToArray()
                                               .Count();

            var deletedCountry = await this.DbContext.Countries
                                                     .FirstOrDefaultAsync(x => x.Id == country.Id);

            Assert.Equal(0, countriesCount);
            Assert.Null(deletedCountry);
        }

        [Fact]
        public async Task GetCountriesCountAsyncWorkCorrectly()
        {
            await this.CreateCountryAsync();
            await this.CreateCountryAsync();

            var expect = this.DbContext.Countries.ToList().Count();
            var actual = await this.Service.GetCountriesCountAsync();

            Assert.Equal(expect, actual);
        }

        private async Task<Country> CreateCountryAsync()
        {
            var country = new Country
            {
                Name = new NLipsum.Core.Word().ToString(),
            };

            await this.DbContext.Countries.AddAsync(country);

            await this.DbContext.SaveChangesAsync();

            this.DbContext.Entry<Country>(country).State = EntityState.Detached;

            return country;
        }
    }
}
