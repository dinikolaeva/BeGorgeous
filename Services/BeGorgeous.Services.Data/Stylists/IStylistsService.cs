namespace BeGorgeous.Services.Data.Stylists
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStylistsService
    {
        Task<IEnumerable<T>> GetByIdAsync<T>(int salonId);
    }
}
