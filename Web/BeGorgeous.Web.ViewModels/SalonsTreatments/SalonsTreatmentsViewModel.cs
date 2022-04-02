namespace BeGorgeous.Web.ViewModels.Treatments
{
    using System;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class SalonsTreatmentsViewModel : IMapFrom<SalonTreatment>
    {
        public int TreatmentId { get; set; }

        public Treatment Treatment { get; set; }

        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public City City { get; set; }
    }
}
