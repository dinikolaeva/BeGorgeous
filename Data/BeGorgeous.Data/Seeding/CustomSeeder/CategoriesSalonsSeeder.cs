namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;

    public class CategoriesSalonsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.CategoriesSalons.Any())
            {
                return;
            }

            var categoriesSalons = new List<CategorySalon>();

            foreach (var salon in dbContext.Salons)
            {
                var salonId = salon.Id;

                var stylists = dbContext.Stylists.Where(s => s.SalonId == salonId).ToList();

                var categories = stylists.Select(c => c.CategoryId).Distinct().ToList();

                foreach (var category in categories)
                {
                    categoriesSalons.Add(new CategorySalon
                    {
                        CategoryId = category,
                        SalonId = salonId,
                    });
                }
            }

            await dbContext.CategoriesSalons.AddRangeAsync(categoriesSalons);
            await dbContext.SaveChangesAsync();
        }
    }
}
