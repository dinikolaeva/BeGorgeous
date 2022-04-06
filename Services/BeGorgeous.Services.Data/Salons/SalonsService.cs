namespace BeGorgeous.Services.Data.Salons
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Common.Repositories;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class SalonsService : ISalonsService
    {
        private readonly IDeletableEntityRepository<Salon> salonsRepository;

        public SalonsService(IDeletableEntityRepository<Salon> salonsRepository)
        {
            this.salonsRepository = salonsRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            IQueryable<Salon> query = this.salonsRepository.All();

            return await query.To<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            IQueryable<Salon> query = this.salonsRepository.All()
                                                           .Where(s => s.Id == id);

            return await query.To<T>().FirstOrDefaultAsync();
        }

        public async Task RateSalonAsync(int id, int rateValue)
        {
            var salon = await this.salonsRepository.All()
                                  .Where(x => x.Id == id)
                                  .FirstOrDefaultAsync();

            var oldValueOfRating = salon.Rating;
            var oldValueOfRatersCount = salon.RatersCount;

            var newRatersCount = oldValueOfRatersCount + 1;
            var newRating = (oldValueOfRating + rateValue) / newRatersCount;

            salon.Rating = newRating;
            salon.RatersCount = newRatersCount;

            await this.salonsRepository.SaveChangesAsync();
        }

        public async Task<int> AddAsync(string name, int countryId, int cityId, string description, string streetAddress, string imageUrl, string phoneNumber, string streetMapUrl)
        {
            var salon = new Salon
            {
                Name = name,
                CountryId = countryId,
                CityId = cityId,
                Description = description,
                StreetAddress = streetAddress,
                ImageUrl = imageUrl,
                PhoneNumber = phoneNumber,
                StreetMapUrl = streetMapUrl,
            };

            await this.salonsRepository.AddAsync(salon);

            await this.salonsRepository.SaveChangesAsync();

            return salon.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var salon = await this.salonsRepository.AllAsNoTracking()
                                                   .Where(x => x.Id == id)
                                                   .FirstOrDefaultAsync();

            this.salonsRepository.Delete(salon);

            await this.salonsRepository.SaveChangesAsync();
        }
    }
}
