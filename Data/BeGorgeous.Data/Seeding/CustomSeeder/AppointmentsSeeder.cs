namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class AppointmentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Appointments.Any())
            {
                return;
            }

            var appointments = new List<Appointment>();

            // Get User Id
            var userId = dbContext.Users
                                  .Where(x => x.Email == GlobalConstants.AccountsSeeding.UserEmail)
                                  .FirstOrDefault()
                                  .Id;

            // Get Salons Ids
            var salonsIds = await dbContext.Salons
                                           .Select(x => x.Id)
                                           .Take(GlobalConstants.SeededDataCounts.Salons)
                                           .ToListAsync();

            foreach (var salonId in salonsIds)
            {
                // Get a Service from each Salon
                var treatmentId = dbContext.SalonsTreatments
                                           .Where(x => x.SalonId == salonId)
                                           .FirstOrDefault()
                                           .TreatmentId;

                // Add Upcoming Appointments
                appointments.Add(new Appointment
                {
                    Id = Guid.NewGuid().ToString(),
                    DateTime = DateTime.UtcNow.AddDays(5),
                    UserId = userId,
                    SalonId = salonId,
                    TreatmentId = treatmentId,
                });

                // Add Past Appointments
                appointments.Add(new Appointment
                {
                    Id = Guid.NewGuid().ToString(),
                    DateTime = DateTime.UtcNow.AddDays(-5),
                    UserId = userId,
                    SalonId = salonId,
                    TreatmentId = treatmentId,
                    Confirmed = true,
                });

                // More Past Appointments for testing the RatePastAppointment option
                appointments.Add(new Appointment
                {
                    Id = Guid.NewGuid().ToString(),
                    DateTime = DateTime.UtcNow.AddDays(-10),
                    UserId = userId,
                    SalonId = salonId,
                    TreatmentId = treatmentId,
                    Confirmed = true,
                });
            }

            await dbContext.AddRangeAsync(appointments);
        }
    }
}
