namespace BeGorgeous.Web.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Services.Data.Countries;
    using BeGorgeous.Web.ViewModels;
    using BeGorgeous.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICountriesService countriesService;

        public HomeController(ICountriesService countriesService)
        {
            this.countriesService = countriesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new IndexViewModel
            {
                Countries =
                     await this.countriesService.GetAllAsync<IndexCountryViewModel>(),
            };

            return this.View(viewModel);
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
