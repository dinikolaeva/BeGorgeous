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

        public CitiesService(IDeletableEntityRepository<City> citiesRepository)
        {
            this.citiesRepository = citiesRepository;
        }

        public async Task<IEnumerable<T>> GetAllCitiesByIdAsync<T>(int sortId)
        {
            var cities = await this.citiesRepository
                                   .All()
                                   .Where(c => c.CountryId == sortId)
                                   .To<T>()
                                   .ToListAsync<T>();

            return cities;
        }
    }
}
