namespace BeGorgeous.Web.ViewModels.Common.SelectedLists
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class CitiesSelectListViewModel : IMapFrom<City>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
