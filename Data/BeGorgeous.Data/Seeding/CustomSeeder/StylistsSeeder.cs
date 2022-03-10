namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using BeGorgeous.Common;
    using BeGorgeous.Data.Models;

    public class StylistsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Stylists.Any())
            {
                return;
            }

            var stylists = new Stylist[]
            {
                // Hair
                new Stylist
                {
                    FullName = "Eva Ivanova",
                    CategoryId = 2,
                    SalonId = "seeded403abb96-c743-408a-ab2a-c2e276cc93c0",
                    ImageUrl = GlobalConstants.Images.EvaIvanova,
                    ShortAutobiography = "Hi, I’m Eva and I’ve been a stylist and colorist for the past 10 years. I love to modernize classic looks to make them fun and wearable for the woman-on-the-go. I attend numerous continuing-ed classes each year so as to always be knowledgeable of the best and healthiest techniques to use.",
                },
                new Stylist
                {
                    FullName = "Anna Nikolova",
                    CategoryId = 2,
                    SalonId = "seeded403abb96-c743-408a-ab2a-c2e276cc93c0",
                    ImageUrl = GlobalConstants.Images.EvaIvanova,
                    ShortAutobiography = "Anna Nikolova is Master Hair Stylist at Be Gorgeous. Her unique approach to balayage hair coloring earned her the prestigious International Hairdressing Award 2022.",
                },
            };
        }
    }
}
