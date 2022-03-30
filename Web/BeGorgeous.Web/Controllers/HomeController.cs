namespace BeGorgeous.Web.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Services.Data.Categories;
    using BeGorgeous.Services.Data.Countries;
    using BeGorgeous.Web.ViewModels;
    using BeGorgeous.Web.ViewModels.Categories;
    using BeGorgeous.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICountriesService countriesService;
        private readonly ICategoriesService categoriesService;

        public HomeController(ICountriesService countriesService, ICategoriesService categoriesService)
        {
            this.countriesService = countriesService;
            this.categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new IndexViewModel
            {
                Countries =
                     await this.countriesService.GetAllAsync<IndexCountryViewModel>(),
            };

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }

        [Route("/Home/Error/404")]
        public IActionResult Error404()
        {
            return this.View();
        }

        [Route("/Home/Error/{code:int}")]
        public IActionResult Error(int code)
        {
            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
