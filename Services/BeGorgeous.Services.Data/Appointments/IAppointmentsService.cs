namespace BeGorgeous.Services.Data.Appointments
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAppointmentsService
    {
        Task<IEnumerable<T>> GetUpcomingByUserAsync<T>(string userId);

        Task<T> GetSalonByIdAsync<T>(int salonId);

        Task AddAsync(string userId, int salonId, int treatmentId, int stylistId, DateTime dateTime);
    }
}
