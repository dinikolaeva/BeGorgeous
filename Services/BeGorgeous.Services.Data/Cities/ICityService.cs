namespace BeGorgeous.Services.Data.Cities
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICityService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task AddAsync(string name, int countryId);

        Task DeleteAsync(int id);
    }
}
