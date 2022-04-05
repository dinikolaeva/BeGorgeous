namespace BeGorgeous.Web.ViewModels.Salons
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class SalonTreatmentViewModel : IMapFrom<SalonTreatment>
    {
        public int SalonId { get; set; }

        public int TreatmentId { get; set; }

        public string TreatmentName { get; set; }
    }
}
