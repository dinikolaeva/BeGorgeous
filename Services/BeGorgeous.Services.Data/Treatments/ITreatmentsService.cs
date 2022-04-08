namespace BeGorgeous.Services.Data.Treatments
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITreatmentsService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task AddAsync(string name, int categoryId, string description, string imageUrl, string iconUrl, TimeSpan duration, decimal price);

        Task DeleteAsync(int id);
    }
}
