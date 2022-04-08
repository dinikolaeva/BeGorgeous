namespace BeGorgeous.Services.Data.Stylists
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStylistsService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task<IEnumerable<T>> GetByIdAsync<T>(int salonId);

        Task AddAsync(string fullName, int salonId, int categoryId, string shortAutobiography, string imageUrl);

        Task DeleteAsync(int id);

        Task<int> GetStylistsCountAsync();
    }
}
