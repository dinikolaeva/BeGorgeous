namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;

    public class CitiesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Cities.Any())
            {
                return;
            }

            var cities = new City[]
            {
                new City { Name = "Sofia", CountryId = 1 },
                new City { Name = "Plovdiv", CountryId = 1 },
                new City { Name = "London", CountryId = 2 },
                new City { Name = "Birmingham", CountryId = 2 },
                new City { Name = "Madrid", CountryId = 3 },
                new City { Name = "Barcelona", CountryId = 3 },
            };

            foreach (var city in cities)
            {
                await dbContext.Cities.AddAsync(city);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
