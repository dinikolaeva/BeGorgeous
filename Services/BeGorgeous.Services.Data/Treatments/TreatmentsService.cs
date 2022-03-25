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
        private readonly IDeletableEntityRepository<SalonTreatment> salonTreatmentRepository;
        private readonly IDeletableEntityRepository<Treatment> treatmentRepository;

        public TreatmentsService(IDeletableEntityRepository<SalonTreatment> salonTreatmentRepository, IDeletableEntityRepository<Treatment> treatmentRepository)
        {
            this.salonTreatmentRepository = salonTreatmentRepository;
            this.treatmentRepository = treatmentRepository;
        }

        public async Task<IEnumerable<T>> GetByIdAsync<T>(int salonId)
        {
            var salonTreatments = await this.salonTreatmentRepository.All()
                                                                   .Where(st => st.SalonId == salonId)
                                                                   .Select(st => st.TreatmentId)
                                                                   .To<T>()
                                                                   .ToListAsync();

            return salonTreatments;
        }
    }
}
