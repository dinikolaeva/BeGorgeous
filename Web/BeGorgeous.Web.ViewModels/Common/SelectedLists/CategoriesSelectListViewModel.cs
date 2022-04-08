namespace BeGorgeous.Web.ViewModels.Common.SelectedLists
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class CategoriesSelectListViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
