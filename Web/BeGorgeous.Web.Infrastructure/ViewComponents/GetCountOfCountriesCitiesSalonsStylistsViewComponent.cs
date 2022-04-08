namespace BeGorgeous.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Cities;
    using BeGorgeous.Services.Data.Countries;
    using BeGorgeous.Services.Data.Salons;
    using BeGorgeous.Services.Data.Stylists;
    using BeGorgeous.Web.ViewModels.Cities;
    using BeGorgeous.Web.ViewModels.Common.CountsForIndexPage;
    using Microsoft.AspNetCore.Mvc;

    public class GetCountOfCountriesCitiesSalonsStylistsViewComponent : ViewComponent
    {
        private readonly ICountriesService countriesService;
        private readonly ICitiesService citiesService;
        private readonly ISalonsService salonsService;
        private readonly IStylistsService stylistsService;

        public GetCountOfCountriesCitiesSalonsStylistsViewComponent(
            ICountriesService countriesService,
            ICitiesService citiesService,
            ISalonsService salonsService,
            IStylistsService stylistsService)
        {
            this.countriesService = countriesService;
            this.citiesService = citiesService;
            this.salonsService = salonsService;
            this.stylistsService = stylistsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var countriesCount = await this.countriesService.GetCountriesCountAsync();
            var citiesCount = await this.citiesService.GetCitiesCountAsync();
            var salons = await this.salonsService.GetSalonsCountAsync();
            var stylists = await this.stylistsService.GetStylistsCountAsync();

            var viewModel = new CountViewModel
            {
                CountriesCount = countriesCount,
                CitiesCount = citiesCount,
                SalonsCount = salons,
                StylistsCount = stylists,
            };

            return this.View(viewModel);
        }
    }
}
