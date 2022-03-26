namespace BeGorgeous.Web.ViewModels.SalonsTreatments
{
    using System.Collections.Generic;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;
    using BeGorgeous.Web.ViewModels.Treatments;

    public class SalonsTreatmentsViewModel : IMapFrom<SalonTreatment>
    {
        public int SalonId { get; set; }

        public int TreatmentId { get; set; }
    }
}
