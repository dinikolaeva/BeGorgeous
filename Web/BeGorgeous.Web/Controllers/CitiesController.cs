namespace BeGorgeous.Web.Controllers
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Cities;
    using BeGorgeous.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class CitiesController : BaseController
    {
        private readonly ICitiesService citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            this.citiesService = citiesService;
        }

        public async Task<IActionResult> Index(int cityId)
        {
            var viewModel = new SalonsListViewModel
            {
                Salons = await this.citiesService.GetAllSalonsByCityIdAsync<SalonViewModel>(cityId),
            };

            return this.View(viewModel);
        }
    }
}
