namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new Category[]
            {
                new Category
                {
                    Name = "Hair",
                    Description = "The right haircut can totally reclassify your look and upgrade your appearance. Our team works in different hair updos that are in accordance with the most recent patterns and gives you an engaging look. Hair needs ordinary consideration, sustenance, styling, and medications. Our well-prepared hairdressers give you the best styling and modify them to fit your personality and hairstyle.",
                    ImageUrl = GlobalConstants.Images.Hairdressing,
                },
                new Category
                {
                    Name = "Nail",
                    Description = "Your hand and feet come first when you do any work like pouring a drink, making a toast or simply walking. A perfect nail treatment gives a silk touch and confidence. Each woman knows that a good makeover is only complete with hands and feet so the nails spa becomes necessary. You’ve got to look your best every single time.",
                    ImageUrl = GlobalConstants.Images.Nails,
                },
                new Category
                {
                    Name = "Wax",
                    Description = "We'll comfort you and show you that waxing doesn’t have to be painful or embarrassing. As hair removal specialists, you can be assured that all our specialists are highly trained..." +
                    "We will feel you sleek, smooth and looking fantastic. We also provide the full range of high- quality pre and post waxing care as we believe it makes a difference to the treatment and therefore your skin.",
                    ImageUrl = GlobalConstants.Images.Waxing,
                },
                new Category
                {
                    Name = "Makeup",
                    Description = "Move seamlessly from day to night with evening make-up that will transform your looks. Whether you want to glam up for a party or go sparkly for a black-tie event, our makeup specialist can add a sophisticated and radiant touch of magic to your make up.",
                    ImageUrl = GlobalConstants.Images.Makeup,
                },
                new Category
                {
                    Name = "Facial",
                    Description = "Take time to relax in our facial salon with one hour of uninterrupted pampering. De-stress while we help your skin glow from the inside out. Enjoy a deeply cleansed skin with custom cleansing to get rid the pores of Comedones to help care for acne.",
                    ImageUrl = GlobalConstants.Images.CosmeticТreatments,
                },
            };

            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(category);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
