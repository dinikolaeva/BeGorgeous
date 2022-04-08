namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;

    public class StylistsTreatmentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.StylistsTreatments.Any())
            {
                return;
            }

            var stylistsTreatments = new List<StylistTreatment>();

            foreach (var stylist in dbContext.Stylists)
            {
                var stylistId = stylist.Id;

                var categoryId = stylist.CategoryId;

                foreach (var treatment in dbContext.Treatments.Where(t => t.CategoryId == categoryId))
                {
                    var treatmentId = treatment.Id;

                    stylistsTreatments.Add(new StylistTreatment
                    {
                        StylistId = stylistId,
                        TreatmentId = treatmentId,
                    });
                }
            }

            foreach (var stylistTreatment in stylistsTreatments)
            {
                await dbContext.StylistsTreatments.AddAsync(stylistTreatment);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
