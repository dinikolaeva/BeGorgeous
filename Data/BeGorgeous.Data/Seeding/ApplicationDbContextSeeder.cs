﻿namespace BeGorgeous.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Seeding.CustomSeeder;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    public class ApplicationDbContextSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(ApplicationDbContextSeeder));

            var seeders = new List<ISeeder>
                          {
                              new RolesSeeder(),
                              new AccountsSeeder(),
                              new CountriesSeeder(),
                              new CitiesSeeder(),
                              new SalonsSeeder(),
                              new CategoriesSeeder(),
                              new StylistsSeeder(),
                              new TreatmentsSeeder(),
                              new CategoriesSalonsSeeder(),
                              new SalonsTreatmentsSeeder(),
                              new StylistsTreatmentsSeeder(),
                              new AppointmentsSeeder(),
                          };

            foreach (var seeder in seeders)
            {
                await seeder.SeedAsync(dbContext, serviceProvider);
                await dbContext.SaveChangesAsync();
                logger.LogInformation($"Seeder {seeder.GetType().Name} done.");
            }
        }
    }
}
