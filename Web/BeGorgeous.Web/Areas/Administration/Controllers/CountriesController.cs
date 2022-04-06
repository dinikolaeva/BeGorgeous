namespace BeGorgeous.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Services.Data.Countries;
    using BeGorgeous.Web.ViewModels.Countries;
    using Microsoft.AspNetCore.Mvc;

    public class CountriesController : AdministrationController
    {
        private readonly ICountriesService countriesService;

        public CountriesController(ICountriesService countriesService)
        {
            this.countriesService = countriesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new CountriesListViewModel
            {
                Countries = await this.countriesService.GetAllAsync<CountryViewModel>(),
            };

            return this.View(viewModel);
        }

        public IActionResult AddCountry()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCountry(CountryInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.countriesService.AddAsync(input.Name);

            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Countries)
            {
                return this.RedirectToAction("Index");
            }

            await this.countriesService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
