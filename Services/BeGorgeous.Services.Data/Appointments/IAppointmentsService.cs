namespace BeGorgeous.Services.Data.Appointments
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAppointmentsService
    {
        Task<T> GetSalonByIdAsync<T>(int salonId);

        Task<T> GetAppointmentByIdAsync<T>(string id);

        Task<IEnumerable<T>> GetAllAppointmentsBySalonAsync<T>(int salonId);

        Task<IEnumerable<T>> GetUpcomingByUserAsync<T>(string userId);

        Task<IEnumerable<T>> GetPastAppointmentsOfUserAsync<T>(string userId);

        Task AddAsync(string userId, int salonId, int treatmentId, DateTime dateTime);

        Task DeleteAsync(string id);

        Task RateAppointmentAsync(string id);

        Task ConfirmAsync(string id);

        Task DeclineAsync(string id);
    }
}
