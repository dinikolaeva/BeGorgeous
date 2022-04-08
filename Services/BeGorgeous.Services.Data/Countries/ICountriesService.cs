namespace BeGorgeous.Services.Data.Countries
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICountriesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task AddAsync(string name);

        Task DeleteAsync(int id);

        Task<int> GetCountriesCountAsync();
    }
}
