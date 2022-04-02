namespace BeGorgeous.Web.ViewModels.Appointments
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class SalonTreatmentsSimpleViewModel : IMapFrom<SalonTreatment>
    {
        public int SalonId { get; set; }

        public int TreatmentId { get; set; }
    }
}
