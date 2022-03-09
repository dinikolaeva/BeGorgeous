﻿namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;

    public class CountrySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Countres.Any())
            {
                return;
            }

            var countries = new Country[]
            {
                new Country { Name = "Bulgaria" } /*Id = 1*/,
                new Country { Name = "United Kingdom" } /*Id = 2*/,
                new Country { Name = "Spain" } /*Id = 3*/,
            };

            foreach (var country in countries)
            {
                await dbContext.Countres.AddAsync(country);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
