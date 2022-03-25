namespace BeGorgeous.Web.ViewModels.SalonsTreatments
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class SalonsTreatmentsViewModel : IMapFrom<SalonTreatment>
    {
        public int SalonId { get; set; }

        public int TreatmentId { get; set; }
    }
}
