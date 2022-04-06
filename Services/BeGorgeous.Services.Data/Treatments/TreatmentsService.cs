namespace BeGorgeous.Services.Data.Treatments
{
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
                                       .To<T>()
                                       .ToListAsync<T>();

            return treatments;
        }
    }
}
