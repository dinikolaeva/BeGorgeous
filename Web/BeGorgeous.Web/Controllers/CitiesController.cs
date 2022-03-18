namespace BeGorgeous.Web.Controllers
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Cities;
    using BeGorgeous.Web.ViewModels.Cities;
    using Microsoft.AspNetCore.Mvc;

    public class CitiesController : BaseController
    {
        private readonly ICitiesService citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            this.citiesService = citiesService;
        }

        public async Task<IActionResult> Index(int sortId)
        {
            var viewModel = new CitiesListViewModel
            {
                Cities = await this.citiesService.GetAllCitiesByIdAsync<CityViewModel>(sortId),
            };
            return this.View(viewModel);
        }
    }
}
