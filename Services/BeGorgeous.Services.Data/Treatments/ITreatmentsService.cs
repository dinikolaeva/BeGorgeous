namespace BeGorgeous.Services.Data.Treatments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITreatmentsService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();
    }
}
