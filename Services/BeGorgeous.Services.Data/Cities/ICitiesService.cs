namespace BeGorgeous.Services.Data.Cities
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICitiesService
    {
        Task<IEnumerable<T>> GetAllCitiesByIdAsync<T>(int sortId);
    }
}
