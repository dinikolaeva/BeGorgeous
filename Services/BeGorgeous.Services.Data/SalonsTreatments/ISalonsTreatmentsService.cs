namespace BeGorgeous.Services.Data.SalonsTreatments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISalonsTreatmentsService
    {
        Task<IEnumerable<T>> GetByIdAsync<T>(int salonId);

        Task<IEnumerable<T>> GetAllByIdsAsync<T>(List<int> ids);

        Task<T> GetTreatmentByIdAsync<T>(int treatmentId);

        Task<T> GetSalonAndTreatmentByIdAsync<T>(int salonId, int treatmentId);

        bool IsSalonIdValid(int salonId);

        bool IsTreatmentAndSalonIdValid(int salonId, int treatmentId);
    }
}
