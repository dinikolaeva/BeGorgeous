namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Models;

    public class TreatmentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Treatments.Any())
            {
                return;
            }

            var treatments = new Treatment[]
            {
                // 1.Hairdressing
                new Treatment
                {
                    Name = "Lady Haircut",
                    CategoryId = 2,
                    Description = "Talking about ladies cut or hair color, there is no single one that is a good match for every woman, but you can be certain there is a style that is right just for you.",
                    Duration = TimeSpan.FromMinutes(50),
                    ImageUrl = GlobalConstants.Images.LadiessHaircuts,
                    Price = GlobalConstants.Prices.LadiesHaircuts,
                },
                new Treatment
                {
                    Name = "Men Haircut",
                    CategoryId = 2,
                    Description = "Fades, fuseys, buzzcuts, crew cuts, brush ups... these days men’s haircuts are as varied as women’s! Whichever hairstyle you go for though, the end result should always be the same when stepping out of the hair salon: a clean and tidy haircut. So fresh!",
                    Duration = TimeSpan.FromMinutes(20),
                    ImageUrl = GlobalConstants.Images.MansHaircuts,
                    Price = GlobalConstants.Prices.MansHaircuts,
                },
                new Treatment
                {
                    Name = "Children Haircut",
                    CategoryId = 2,
                    Description = "Your baby’s first haircut can be a nervous time for parent and child alike, but with the right preparation, you can turn a snippy situation into a beautiful moment for you both.",
                    Duration = TimeSpan.FromMinutes(40),
                    ImageUrl = GlobalConstants.Images.ChildrensHaircuts,
                    Price = GlobalConstants.Prices.ChildrensHaircuts,
                },
                new Treatment
                {
                    Name = "Blow-dry",
                    CategoryId = 2,
                    Description = "Blow-drying is the preferred method for hair straightening without chemical treatment. Blow-drying gives hair volume. Let our hairstylist give your hair brilliance and shine.",
                    Duration = TimeSpan.FromMinutes(25),
                    ImageUrl = GlobalConstants.Images.BlowDry,
                    Price = GlobalConstants.Prices.BlowDry,
                },
                new Treatment
                {
                    Name = "Ladies hair coloring",
                    CategoryId = 2,
                    Description = "There was a time when choosing a hair color was limited to blonde, red, brown and black. Those days are now long gone. Each primary color is now available in the full range of shades, from pale blond to black.",
                    Duration = TimeSpan.FromMinutes(90),
                    ImageUrl = GlobalConstants.Images.LadiesHairColoring,
                    Price = GlobalConstants.Prices.LadiesHairColoring,
                },

                // TODO:Initialize seeder in dbContext
            };
        }
    }
}
