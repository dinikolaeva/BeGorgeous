namespace BeGorgeous.Web.ViewModels.Categories
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
