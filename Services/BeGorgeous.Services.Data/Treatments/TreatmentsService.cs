namespace BeGorgeous.Services.Data.Treatments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Common.Repositories;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class TreatmentsService : ITreatmentsService
    {
        private readonly IDeletableEntityRepository<Treatment> treatmentsRepository;

        public TreatmentsService(IDeletableEntityRepository<Treatment> treatmentsRepository)
        {
            this.treatmentsRepository = treatmentsRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var treatments = await this.treatmentsRepository.All()
                                       .OrderBy(x => x.Category)
                                       .ThenBy(x => x.Id)
                                       .To<T>()
                                       .ToListAsync<T>();

            return treatments;
        }

        public async Task AddAsync(string name, int categoryId, string description, string imageUrl, string iconUrl, TimeSpan duration, decimal price)
        {
            var treatment = new Treatment
            {
                Name = name,
                CategoryId = categoryId,
                Description = description,
                ImageUrl = imageUrl,
                IconUrl = iconUrl,
                Duration = duration,
                Price = price,
            };

            await this.treatmentsRepository.AddAsync(treatment);

            await this.treatmentsRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var treatment = await this.treatmentsRepository.AllAsNoTracking()
                                                           .Where(x => x.Id == id)
                                                           .FirstOrDefaultAsync();

            this.treatmentsRepository.Delete(treatment);

            await this.treatmentsRepository.SaveChangesAsync();
        }
    }
}
