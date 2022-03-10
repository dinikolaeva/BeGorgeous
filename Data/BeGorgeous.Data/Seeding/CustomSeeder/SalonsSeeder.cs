namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Models;

    public class SalonsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Salons.Any())
            {
                return;
            }

            var salons = new Salon[]
            {
                new Salon
                {
                    Id = "seeded" + Guid.NewGuid().ToString(),
                    Name = "Be Gorgeous in Sofia",
                    CityId = 1,
                    Description = "Whether you want to get a simple, classic hair cut or you want to get a personalized look from the stylists, Be Gorgeous salon is for you. We offer a range of services starting from hair styling, hair coloring, makeup, eyelash extensions to skincare, hair removal and facial treatments.",
                    ImageUrl = GlobalConstants.Images.BeGorgeousInSofia,
                    PhoneNumber = "0888888888",
                    RatersCount = 0,
                    Rating = 0.0,
                    StreetAddress = "St. Jozef 135",
                },
                new Salon
                {
                    Id = "seeded" + Guid.NewGuid().ToString(),
                    Name = "Be Gorgeous in Plovdiv",
                    CityId = 2,
                    Description = "If you are looking for high-quality skin and hair care, then Be Gorgeous is the place for you. This salon offers a range of great services and hairstylists here also provide recommendations so that you can get the best-recommended hairstyles suiting your personality.",
                    ImageUrl = GlobalConstants.Images.BeGorgeousInPlovdiv,
                    PhoneNumber = "0888888881",
                    RatersCount = 0,
                    Rating = 0.0,
                    StreetAddress = "Maria Luiza 450",
                },
                new Salon
                {
                    Id = "seeded" + Guid.NewGuid().ToString(),
                    Name = "Be Gorgeous in London",
                    CityId = 3,
                    Description = "One of the striking features about the Be Gorgeous is its expert people and staff. The highly experienced and skilled hairstylists help you to get the best haircut and hairstyle, personalized and suiting your required demands. The salon is highly specialized in offering comprehensive hair care ranging from hair color, haircut, bridal, treatments, up-dos, and foiling.",
                    ImageUrl = GlobalConstants.Images.BeGorgeousInLondon,
                    PhoneNumber = "+442045777777",
                    RatersCount = 0,
                    Rating = 0.0,
                    StreetAddress = "78 Grange Road",
                },
                new Salon
                {
                    Id = "seeded" + Guid.NewGuid().ToString(),
                    Name = "Be Gorgeous in Birmingham",
                    CityId = 4,
                    Description = "Be Gorgeous salons offer a range of top-end hairstyling that is inspired by trends all across the globe. Right from precision haircuts to coloring, waxing services to bridal and makeup services, you can find every hair and makeup service here.",
                    ImageUrl = GlobalConstants.Images.BeGorgeousInBirmingham,
                    PhoneNumber = "+442045565656",
                    RatersCount = 0,
                    Rating = 0.0,
                    StreetAddress = "568 Elize Lopen",
                },
                new Salon
                {
                    Id = "seeded" + Guid.NewGuid().ToString(),
                    Name = "Be Gorgeous in Madrid",
                    CityId = 5,
                    Description = "We realize that your hair is your signature and that you must feel great about it every day. The success of our business has been, and will always be, based on paying attention to the details – the many details that ensure quality.",
                    ImageUrl = GlobalConstants.Images.BeGorgeousInMadrid,
                    PhoneNumber = "+34919930316",
                    RatersCount = 0,
                    Rating = 0.0,
                    StreetAddress = "Calle de Raimundo Fernández Villaverde 9",
                },
                new Salon
                {
                    Id = "seeded" + Guid.NewGuid().ToString(),
                    Name = "Be Gorgeous in Barcelona",
                    CityId = 6,
                    Description = "This premier salon is located in Barcelona. The salon promises to offer a contemporary atmosphere for all its clients. From hair styling and cutting to blow dry and hair coloring, you can choose from these services offered by Be Gorgeous.",
                    ImageUrl = GlobalConstants.Images.BeGorgeousInBarcelona,
                    PhoneNumber = "+34919933333",
                    RatersCount = 0,
                    Rating = 0.0,
                    StreetAddress = "Carrer de Peracamps 20",
                },
            };

            foreach (var salon in salons)
            {
                await dbContext.Salons.AddAsync(salon);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
