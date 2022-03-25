namespace BeGorgeous.Web.ViewModels.Stylists
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class StylistViewModel : IMapFrom<Stylist>
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int SalonId { get; set; }

        public Category Category { get; set; }

        public string ShortAutobiography { get; set; }

        public string ImageUrl { get; set; }
    }
}
