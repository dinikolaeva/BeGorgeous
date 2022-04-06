namespace BeGorgeous.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Services.Data.Cities;
    using BeGorgeous.Services.Data.Countries;
    using BeGorgeous.Web.ViewModels.Cities;
    using BeGorgeous.Web.ViewModels.Common.SelectedLists;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class CitiesController : AdministrationController
    {
        private readonly ICitiesService citiesService;
        private readonly ICountriesService countriesService;

        public CitiesController(ICitiesService citiesService, ICountriesService countriesService)
        {
            this.citiesService = citiesService;
            this.countriesService = countriesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new CitiesListViewModel
            {
                Cities = await this.citiesService.GetAllAsync<CityViewModel>(),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> AddCity()
        {
            var countries = await this.countriesService.GetAllAsync<CountriesSelectListViewModel>();

            this.ViewData["Countries"] = new SelectList(countries, "Id", "Name");

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCity(CityInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.citiesService.AddAsync(input.Name, input.CountryId);

            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCity(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Cities)
            {
                return this.RedirectToAction("Index");
            }

            await this.citiesService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
