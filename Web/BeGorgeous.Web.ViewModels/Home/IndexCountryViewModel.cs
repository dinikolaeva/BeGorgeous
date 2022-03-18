namespace BeGorgeous.Web.ViewModels.Home
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class IndexCountryViewModel : IMapFrom<Country>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
