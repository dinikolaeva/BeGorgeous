namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;

    public class SalonsTreatmentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.SalonsTreatments.Any())
            {
                return;
            }

            var salonTreatments = new List<SalonTreatment>();

            foreach (var categorySalon in dbContext.CategoriesSalons)
            {
                var salonId = categorySalon.SalonId;
                var categoryId = categorySalon.CategoryId;

                foreach (var treatment in dbContext.Treatments.Where(t => t.CategoryId == categoryId))
                {
                    var treatmentId = treatment.Id;

                    salonTreatments.Add(new SalonTreatment
                    {
                        SalonId = salonId,
                        TreatmentId = treatmentId,
                    });
                }
            }

            foreach (var salonTreatment in salonTreatments)
            {
                await dbContext.SalonsTreatments.AddAsync(salonTreatment);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
