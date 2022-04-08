namespace BeGorgeous.Services.Data.Stylists
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Common.Repositories;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class StylistsService : IStylistsService
    {
        private readonly IDeletableEntityRepository<Stylist> stylistsRepository;

        public StylistsService(IDeletableEntityRepository<Stylist> stylistsRepository)
        {
            this.stylistsRepository = stylistsRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var stylists = await this.stylistsRepository.All()
                                                        .OrderBy(x => x.Id)
                                                        .To<T>()
                                                        .ToListAsync();

            return stylists;
        }

        public async Task<IEnumerable<T>> GetByIdAsync<T>(int salonId)
        {
            var stylists = await this.stylistsRepository.All()
                                                        .Where(s => s.SalonId == salonId)
                                                        .OrderBy(x => x.CategoryId)
                                                        .To<T>()
                                                        .ToListAsync();

            return stylists;
        }

        public async Task AddAsync(string fullName, int salonId, int categoryId, string shortAutobiography, string imageUrl)
        {
            var stylist = new Stylist
            {
                FullName = fullName,
                SalonId = salonId,
                CategoryId = categoryId,
                ShortAutobiography = shortAutobiography,
                ImageUrl = imageUrl,
            };

            await this.stylistsRepository.AddAsync(stylist);

            await this.stylistsRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var stylist = await this.stylistsRepository.AllAsNoTracking()
                                                       .Where(x => x.Id == id)
                                                       .FirstOrDefaultAsync();

            this.stylistsRepository.Delete(stylist);

            await this.stylistsRepository.SaveChangesAsync();
        }

        public async Task<int> GetStylistsCountAsync()
        {
            var stylists = await this.stylistsRepository.All().ToListAsync();

            return stylists.Count;
        }
    }
}
