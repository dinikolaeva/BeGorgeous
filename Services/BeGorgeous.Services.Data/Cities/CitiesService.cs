namespace BeGorgeous.Services.Data.Cities
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Common.Repositories;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class CitiesService : ICitiesService
    {
        private readonly IDeletableEntityRepository<City> citiesRepository;
        private readonly IDeletableEntityRepository<Salon> salonsRepository;

        public CitiesService(IDeletableEntityRepository<City> citiesRepository, IDeletableEntityRepository<Salon> salonsRepository)
        {
            this.citiesRepository = citiesRepository;
            this.salonsRepository = salonsRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var cities = await this.citiesRepository
                                   .All()
                                   .OrderBy(x => x.Id)
                                   .To<T>()
                                   .ToListAsync<T>();

            return cities;
        }

        public async Task<IEnumerable<T>> GetAllSalonsByCityIdAsync<T>(int cityId)
        {
            var salons = await this.salonsRepository.All()
                                                    .Where(s => s.CityId == cityId)
                                                    .OrderBy(s => s.Id)
                                                    .To<T>()
                                                    .ToListAsync();

            return salons;
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
