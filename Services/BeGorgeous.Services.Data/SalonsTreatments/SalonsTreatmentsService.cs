namespace BeGorgeous.Services.Data.SalonsTreatments
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Common.Repositories;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class SalonsTreatmentsService : ISalonsTreatmentsService
    {
        private readonly IDeletableEntityRepository<SalonTreatment> salonsTreatmentsRepository;
        private readonly IDeletableEntityRepository<Treatment> treatmentRepository;

        public SalonsTreatmentsService(IDeletableEntityRepository<SalonTreatment> salonsTreatmentsRepository, IDeletableEntityRepository<Treatment> treatmentRepository)
        {
            this.salonsTreatmentsRepository = salonsTreatmentsRepository;
            this.treatmentRepository = treatmentRepository;
        }

        public async Task<IEnumerable<T>> GetByIdAsync<T>(int salonId)
        {
            var salonsTreatment = await this.salonsTreatmentsRepository
                                            .All()
                                            .Where(st => st.SalonId == salonId)
                                            .To<T>()
                                            .ToListAsync();

            return salonsTreatment;
        }

        public async Task<IEnumerable<T>> GetAllByIdsAsync<T>(List<int> ids)
        {
            var treatments = await this.treatmentRepository
                                       .All()
                                       .Where(t => ids.Contains(t.Id))
                                       .OrderBy(t => t.CategoryId)
                                       .To<T>()
                                       .ToListAsync();

            return treatments;
        }

        public async Task<T> GetTreatmentByIdAsync<T>(int treatmentId)
        {
            var treatment = await this.treatmentRepository
                                      .All()
                                      .Where(t => t.Id == treatmentId)
                                      .To<T>()
                                      .FirstOrDefaultAsync();

            return treatment;
        }
    }
}
