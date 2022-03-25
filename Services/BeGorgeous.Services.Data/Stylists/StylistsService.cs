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

        public async Task<IEnumerable<T>> GetByIdAsync<T>(int salonId)
        {
            var stylists = await this.stylistsRepository.All()
                .Where(s => s.SalonId == salonId)
                .To<T>().ToListAsync();

            return stylists;
        }
    }
}
