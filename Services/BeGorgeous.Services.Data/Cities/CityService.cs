namespace BeGorgeous.Services.Data.Cities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Common.Repositories;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class CityService : ICityService
    {
        private readonly IDeletableEntityRepository<City> citiesRepository;

        public CityService(IDeletableEntityRepository<City> citiesRepository)
        {
            this.citiesRepository = citiesRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var cities = await this.citiesRepository
                                   .All()
                                   .OrderBy(x => x.Id)
                                   .To<T>()
                                   .ToListAsync();

            return cities;
        }

        public async Task AddAsync(string name, int countryId)
        {
            await this.citiesRepository.AddAsync(new City
            {
                Name = name,
                CountryId = countryId,
            });
            await this.citiesRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var city = await this.citiesRepository
                                 .AllAsNoTracking()
                                 .Where(x => x.Id == id)
                                 .FirstOrDefaultAsync();

            this.citiesRepository.Delete(city);
            await this.citiesRepository.SaveChangesAsync();
        }
    }
}
