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
                    CategoryId = 1,
                    Description = "Talking about ladies cut or hair color, there is no single one that is a good match for every woman, but you can be certain there is a style that is right just for you.",
                    Duration = TimeSpan.FromMinutes(50),
                    ImageUrl = GlobalConstants.Images.LadiessHaircuts,
                    IconUrl = GlobalConstants.Icons.LadyHaircut,
                    Price = GlobalConstants.Prices.LadiesHaircuts,
                },
                new Treatment
                {
                    Name = "Men Haircut",
                    CategoryId = 1,
                    Description = "Fades, fuseys, buzzcuts, crew cuts, brush ups... these days men’s haircuts are as varied as women’s! Whichever hairstyle you go for though, the end result should always be the same when stepping out of the hair salon: a clean and tidy haircut. So fresh!",
                    Duration = TimeSpan.FromMinutes(20),
                    ImageUrl = GlobalConstants.Images.MansHaircuts,
                    IconUrl= GlobalConstants.Icons.MenHaircut,
                    Price = GlobalConstants.Prices.MansHaircuts,
                },
                new Treatment
                {
                    Name = "Children Haircut",
                    CategoryId = 1,
                    Description = "Your baby’s first haircut can be a nervous time for parent and child alike, but with the right preparation, you can turn a snippy situation into a beautiful moment for you both.",
                    Duration = TimeSpan.FromMinutes(40),
                    ImageUrl = GlobalConstants.Images.ChildrensHaircuts,
                    IconUrl = GlobalConstants.Icons.ChildrenHaircut,
                    Price = GlobalConstants.Prices.ChildrensHaircuts,
                },
                new Treatment
                {
                    Name = "Blow-dry",
                    CategoryId = 1,
                    Description = "Blow-drying is the preferred method for hair straightening without chemical treatment. Blow-drying gives hair volume. Let our hairstylist give your hair brilliance and shine.",
                    Duration = TimeSpan.FromMinutes(25),
                    ImageUrl = GlobalConstants.Images.BlowDry,
                    IconUrl = GlobalConstants.Icons.BlowDry,
                    Price = GlobalConstants.Prices.BlowDry,
                },
                new Treatment
                {
                    Name = "Press straightening",
                    CategoryId = 1,
                    Description = "Hair style always depends on the occasion, whatever that may be. It’s always a good idea to have your hair done in advance, so don’t wait – schedule an appointment at one of our salons, now!",
                    Duration = TimeSpan.FromMinutes(25),
                    ImageUrl = GlobalConstants.Images.PressStraightening,
                    IconUrl = GlobalConstants.Icons.PressStraightening,
                    Price = GlobalConstants.Prices.PressStraightening,
                },
                new Treatment
                {
                    Name = "Ladies hair coloring",
                    CategoryId = 1,
                    Description = "There was a time when choosing a hair color was limited to blonde, red, brown and black. Those days are now long gone. Each primary color is now available in the full range of shades, from pale blond to black.",
                    Duration = TimeSpan.FromMinutes(60),
                    ImageUrl = GlobalConstants.Images.LadiesHairColoring,
                    IconUrl = GlobalConstants.Icons.LadiesHairColoring,
                    Price = GlobalConstants.Prices.LadiesHairColoring,
                },
                new Treatment
                {
                    Name = "Balayage hair coloring",
                    CategoryId = 1,
                    Description = "Balayage hair color basically works for all lengths of hair, except perhaps very short-cropped hair. But best of all, It’s bespoke to you.",
                    Duration = TimeSpan.FromMinutes(45),
                    ImageUrl = GlobalConstants.Images.BalayageHairColoring,
                    IconUrl= GlobalConstants.Icons.BalayageHairColoring,
                    Price = GlobalConstants.Prices.BalayageHairColoring,
                },
                new Treatment
                {
                    Name = "Botox therapy",
                    CategoryId = 1,
                    Description = "Botox therapy is a long-term therapy. The effect of it is visible from the first time. The hair becomes softer, livelier, thicker, shiny and falls heavier.",
                    Duration = TimeSpan.FromMinutes(20),
                    ImageUrl = GlobalConstants.Images.BotoxTherapy,
                    IconUrl = GlobalConstants.Icons.BotoxTherapy,
                    Price = GlobalConstants.Prices.BotoxTherapy,
                },
                new Treatment
                {
                    Name = "Braids",
                    CategoryId = 1,
                    Description = "Braided hairstyles are a hit at prom, formal and casual styles. Apparently this pretty fashion never lost influence and for good reason – these styles are comfortable, durable and very efficient, braids can be made on a very short and very long hair.",
                    Duration = TimeSpan.FromMinutes(30),
                    ImageUrl = GlobalConstants.Images.Braids,
                    IconUrl = GlobalConstants.Icons.Braids,
                    Price = GlobalConstants.Prices.Braids,
                },

                // 2. Nails
                new Treatment
                {
                    Name = "Manicure",
                    CategoryId = 2,
                    Description = "Undeniable fact is that one of the first things that make an impression on people is the appearance of your hands and your nails.",
                    Duration = TimeSpan.FromMinutes(60),
                    ImageUrl = GlobalConstants.Images.Manicure,
                    IconUrl = GlobalConstants.Icons.Manicure,
                    Price = GlobalConstants.Prices.Manicure,
                },
                new Treatment
                {
                    Name = "Pedicure",
                    CategoryId = 2,
                    Description = "Pedicure means taking care of your feet. The treatment includes removal of dead cells from the feet, cleaning and shaping the nails. The massage in turn improves blood circulation and acts to remove fatigue in the legs.",
                    Duration = TimeSpan.FromMinutes(60),
                    ImageUrl = GlobalConstants.Images.Pedicure,
                    IconUrl= GlobalConstants.Icons.Pedicure,
                    Price = GlobalConstants.Prices.Pedicure,
                },
                new Treatment
                {
                    Name = "Nail art",
                    CategoryId = 2,
                    Description = "Nail art is a creative way to decorate & design the nails. It brings out the creative imagination of the nail technician. It creates a beautiful finish on polish nail art. It has become the fashion on nails today.",
                    Duration = TimeSpan.FromMinutes(60),
                    ImageUrl = GlobalConstants.Images.NailArt,
                    IconUrl = GlobalConstants.Icons.NailArt,
                    Price = GlobalConstants.Prices.NailArt,
                },

                // 3. Wax
                new Treatment
                {
                    Name = "Full body wax",
                    CategoryId = 3,
                    Description = "All depilation treatments are carried out at the wax salon discretion by one of our fully trained therapists. Our waxing treatments consist of using warm strip wax depending on the type of hair removal and area to be treated.",
                    Duration = TimeSpan.FromMinutes(60),
                    ImageUrl = GlobalConstants.Images.FullBodyWaxing,
                    IconUrl = GlobalConstants.Icons.FullBodyWax,
                    Price = GlobalConstants.Prices.FullBodyWaxing,
                },
                new Treatment
                {
                    Name = "Brazilian wax",
                    CategoryId = 3,
                    Description = "Brazilian waxing is very popular these days. A Brazilian Wax is the next step from the full bikini wax. A Brazilian Wax is the method that removes all the hair from the frontal part of your bikini area.",
                    Duration = TimeSpan.FromMinutes(30),
                    ImageUrl = GlobalConstants.Images.BrazilianWaxing,
                    IconUrl = GlobalConstants.Icons.BrazilianWax,
                    Price = GlobalConstants.Prices.BrazilianWaxing,
                },

                // 4. Makeup
                new Treatment
                {
                    Name = "Professional makeup",
                    CategoryId = 4,
                    Description = "We will help you choose the most stylish vision and provide you with the most appropriate services to achieve it. The comfortable and relaxing atmosphere in our salons will make you feel at home! Do not delay, save an hour now!",
                    Duration = TimeSpan.FromMinutes(60),
                    ImageUrl = GlobalConstants.Images.ProfessionalMakeup,
                    IconUrl = GlobalConstants.Icons.ProfessionalMakeup,
                    Price = GlobalConstants.Prices.ProfessionalMakeup,
                },
                new Treatment
                {
                    Name = "Permanent makeup",
                    CategoryId = 4,
                    Description = "Permanent makeup or micro-pigmentation is a treatment in which natural dyes are injected between the dermis and epidermis. The treatment resembles tattooing, but its durability is not more than 3-4 years.",
                    Duration = TimeSpan.FromMinutes(40),
                    ImageUrl = GlobalConstants.Images.PermanentMakeup,
                    IconUrl = GlobalConstants.Icons.PermanentMakeup,
                    Price = GlobalConstants.Prices.PermanentMakeup,
                },
                new Treatment
                {
                    Name = "Eyelashes extension",
                    CategoryId = 4,
                    Description = "Eyelashes of strands and eyelashes \"hair by hair\" are glued with a special harmless and hypoallergenic adhesive. The lashes last from ten days to one month. The result is really unique!",
                    Duration = TimeSpan.FromMinutes(50),
                    ImageUrl = GlobalConstants.Images.EyelashesExtension,
                    IconUrl = GlobalConstants.Images.EyelashesExtension,
                    Price = GlobalConstants.Prices.EyelashesExtension,
                },

                // 5. Facial
                new Treatment
                {
                    Name = "Facial cleaning",
                    CategoryId = 5,
                    Description = "The ultrasonic peel removes the surface layer of dead cells - the skin regenerates, refreshes and softens. It allows us to clean without redness and scarring.",
                    Duration = TimeSpan.FromMinutes(60),
                    ImageUrl = GlobalConstants.Images.FacialCleaning,
                    IconUrl = GlobalConstants.Icons.FacialCleaning,
                    Price = GlobalConstants.Prices.FacialCleaning,
                },
                new Treatment
                {
                    Name = "Anti age care facial",
                    CategoryId = 5,
                    Description = "If you want to fight the war against wrinkles, an anti-aging facial treatment at your favorite spa is a good strategy. Facials are designed to revive skin with all elements like exfoliation dead skin cells, improving circulation acting together to improve skin’s texture.",
                    Duration = TimeSpan.FromMinutes(60),
                    ImageUrl = GlobalConstants.Images.AntiAgeCareFacial,
                    IconUrl= GlobalConstants.Images.AntiAgeCareFacial,
                    Price = GlobalConstants.Prices.AntiAgeCareFacial,
                },
                new Treatment
                {
                    Name = "Anti acne facial",
                    CategoryId = 5,
                    Description = "If you want to fight the war against wrinkles, an anti-aging facial treatment at your favorite spa is a good strategy. Facials are designed to revive skin with all elements like exfoliation dead skin cells, improving circulation acting together to improve skin’s texture.",
                    Duration = TimeSpan.FromMinutes(60),
                    ImageUrl = GlobalConstants.Images.AntiAcneFacial,
                    IconUrl= GlobalConstants.Icons.AntiAcneFacial,
                    Price = GlobalConstants.Prices.AntiAcneFacial,
                },
                new Treatment
                {
                    Name = "Diamond Dermabrasion",
                    CategoryId = 5,
                    Description = "Dermabrasion is a procedure for smoothing the entire face or individual parts of the face. This is achieved by controlled surgical abrasion of the damaged skin of the face. Dermabrasion smooths the skin and makes it look younger.",
                    Duration = TimeSpan.FromMinutes(60),
                    ImageUrl = GlobalConstants.Images.DiamondDermabrasion,
                    IconUrl = GlobalConstants.Icons.DiamondDermabrasion,
                    Price = GlobalConstants.Prices.DiamondDermabrasion,
                },
            };

            foreach (var treatment in treatments)
            {
                await dbContext.Treatments.AddAsync(treatment);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
