namespace BeGorgeous.Services.Data.Salons
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISalonsService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task<T> GetByIdAsync<T>(int id);

        Task RateSalonAsync(int id, int rateValue);
    }
}
