namespace BeGorgeous.Services.Data.Appointments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Common.Repositories;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class AppointmentsService : IAppointmentsService
    {
        private readonly IDeletableEntityRepository<Appointment> appointmentsRepository;
        private readonly IDeletableEntityRepository<Salon> salonsRepository;

        public AppointmentsService(IDeletableEntityRepository<Appointment> appointmentsRepository, IDeletableEntityRepository<Salon> salonsRepository)
        {
            this.appointmentsRepository = appointmentsRepository;
            this.salonsRepository = salonsRepository;
        }

        public async Task<IEnumerable<T>> GetUpcomingByUserAsync<T>(string userId)
        {
            var appointments =
                await this.appointmentsRepository.All()
                          .Where(x => x.UserId == userId && x.DateTime.Date > DateTime.UtcNow.Date)
                          .OrderBy(x => x.DateTime)
                          .To<T>()
                          .ToListAsync();

            return appointments;
        }

        public async Task<T> GetSalonByIdAsync<T>(int salonId)
        {
            var salon = await this.salonsRepository.All()
                                                   .Where(s => s.Id == salonId)
                                                   .To<T>()
                                                   .FirstOrDefaultAsync();

            return salon;
        }

        public async Task AddAsync(string userId, int salonId, int treatmentId, int stylistId, DateTime dateTime)
        {
            await this.appointmentsRepository.AddAsync(new Appointment
            {
                Id = Guid.NewGuid().ToString(),
                DateTime = dateTime,
                UserId = userId,
                SalonId = salonId,
                TreatmentId = treatmentId,
                StylistId = stylistId,
            });

            await this.appointmentsRepository.SaveChangesAsync();
        }
    }
}
