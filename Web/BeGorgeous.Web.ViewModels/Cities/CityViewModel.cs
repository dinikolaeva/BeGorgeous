namespace BeGorgeous.Web.ViewModels.Cities
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class CityViewModel : IMapFrom<City>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
