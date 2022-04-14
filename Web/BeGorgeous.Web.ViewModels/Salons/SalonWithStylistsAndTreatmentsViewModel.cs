namespace BeGorgeous.Web.ViewModels.Salons
{
    using System.Collections.Generic;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class SalonWithStylistsAndTreatmentsViewModel : IMapFrom<Salon>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public Country Country { get; set; }

        public City City { get; set; }

        public string StreetAddress { get; set; }

        public string PhoneNumber { get; set; }

        public double Rating { get; set; }

        public int RatersCount { get; set; }

        public string Description { get; set; }

        public string StreetMapUrl { get; set; }

        public ICollection<SalonTreatmentViewModel> Treatments { get; set; }
    }
}
