namespace BeGorgeous.Web.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Cities;
    using BeGorgeous.Services.Data.Countries;
    using BeGorgeous.Web.ViewModels;
    using BeGorgeous.Web.ViewModels.Cities;
    using BeGorgeous.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICountriesService countriesService;
        private readonly ICitiesService citiesService;

        public HomeController(ICountriesService countriesService, ICitiesService citiesService)
        {
            this.countriesService = countriesService;
            this.citiesService = citiesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new IndexViewModel
            {
                Countries = await this.countriesService.GetAllAsync<IndexCountryViewModel>(),

                Cities = await this.citiesService.GetAllAsync<CityViewModel>(),
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
