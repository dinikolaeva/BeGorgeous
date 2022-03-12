namespace BeGorgeous.Services.Data.Countries
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICountryService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task AddAsync(string name);

        Task DeleteAsync(int id);
    }
}
