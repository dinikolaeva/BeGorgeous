namespace BeGorgeous.Services.Data.Countries
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Common.Repositories;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class CountriesService : ICountriesService
    {
        private readonly IDeletableEntityRepository<Country> countriesRepository;

        public CountriesService(IDeletableEntityRepository<Country> countriesRepository)
        {
            this.countriesRepository = countriesRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            IQueryable<Country> query = this.countriesRepository
                                            .All()
                                            .OrderBy(x => x.Id);

            return await query.To<T>().ToListAsync();
        }

        public async Task AddAsync(string name)
        {
            await this.countriesRepository.AddAsync(new Country
            {
                Name = name,
            });

            await this.countriesRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var country = await this.countriesRepository
                                    .AllAsNoTracking()
                                    .Where(c => c.Id == id)
                                    .FirstOrDefaultAsync();
        }
    }
}
