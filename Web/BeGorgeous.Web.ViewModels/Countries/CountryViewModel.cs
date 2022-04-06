namespace BeGorgeous.Web.ViewModels.Countries
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class CountryViewModel : IMapFrom<Country>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CitiesCount { get; set; }
    }
}
