namespace BeGorgeous.Services.Data.Tests.UseInMemoryDatabase
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Data.Cities;
    using BeGorgeous.Web.ViewModels.Cities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class CitiesServiceTests : BaseServiceTests
    {
        private ICitiesService Service => this.ServiceProvider.GetRequiredService<ICitiesService>();

        // TODO: Task<IEnumerable<T>> GetAllAsync<T>();
        // TODO: Task<IEnumerable<T>> GetAllSalonsByCityIdAsync<T>(int cityId);

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            await this.CreateCityAsync();

            var name = new NLipsum.Core.Word().ToString();

            await this.Service.AddAsync(name, 1);

            var citiesCount = await this.DbContext.Cities.CountAsync();

            Assert.Equal(2, citiesCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var city = await this.CreateCityAsync();

            await this.Service.DeleteAsync(city.Id);

            var citiesCount = this.DbContext.Cities
                                            .Where(x => !x.IsDeleted)
                                            .ToArray()
                                            .Count();

            var deletedCity = await this.DbContext.Cities
                                                  .FirstOrDefaultAsync(x => x.Id == city.Id);
            Assert.Equal(0, citiesCount);
            Assert.Null(deletedCity);
        }

        [Fact]
        public async Task GetCitiesCountAsyncWorkCorrectly()
        {
            await this.CreateCityAsync();
            await this.CreateCityAsync();

            var expect = this.DbContext.Cities
                                            .ToList()
                                            .Count();

            var actual = await this.Service.GetCitiesCountAsync();

            Assert.Equal(expect, actual);
        }

        private async Task<City> CreateCityAsync()
        {
            var city = new City
            {
                Name = new NLipsum.Core.Word().ToString(),
            };

            await this.DbContext.Cities.AddAsync(city);

            await this.DbContext.SaveChangesAsync();

            this.DbContext.Entry<City>(city).State = EntityState.Detached;

            return city;
        }
    }
}
