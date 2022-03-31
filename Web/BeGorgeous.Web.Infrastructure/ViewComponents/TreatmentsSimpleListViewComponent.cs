namespace BeGorgeous.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Cities;
    using BeGorgeous.Web.ViewModels.Cities;
    using Microsoft.AspNetCore.Mvc;

    public class TreatmentsSimpleListViewComponent : ViewComponent
    {
        private readonly ICitiesService citiesService;

        public TreatmentsSimpleListViewComponent(ICitiesService citiesService)
        {
            this.citiesService = citiesService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new CitiesListViewModel
            {
                Cities = await this.citiesService.GetAllAsync<CityViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
