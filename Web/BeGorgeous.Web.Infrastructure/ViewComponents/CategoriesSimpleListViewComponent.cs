namespace BeGorgeous.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Categories;
    using BeGorgeous.Web.ViewModels.Categories;
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesSimpleListViewComponent : ViewComponent
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesSimpleListViewComponent(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new CategoriesListViewModel
            {
                Categories = await this.categoriesService.GetAllAsync<CategoryViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
