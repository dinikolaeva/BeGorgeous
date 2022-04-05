namespace BeGorgeous.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Salons;
    using BeGorgeous.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class MangeSalonsDashboardViewComponent : ViewComponent
    {
        private readonly ISalonsService salonsService;

        public MangeSalonsDashboardViewComponent(ISalonsService salonsService)
        {
            this.salonsService = salonsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new SalonsListViewModel
            {
                Salons = await this.salonsService.GetAllAsync<SalonViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
