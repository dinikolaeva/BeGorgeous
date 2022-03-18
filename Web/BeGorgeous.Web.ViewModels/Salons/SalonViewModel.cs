namespace BeGorgeous.Web.ViewModels.Salons
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class SalonViewModel : IMapFrom<Salon>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string StreetAddress { get; set; }

        public string PhoneNumber { get; set; }

        public double Rating { get; set; }

        public int RatersCount { get; set; }
    }
}
