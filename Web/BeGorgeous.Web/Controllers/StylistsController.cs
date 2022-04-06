namespace BeGorgeous.Web.Controllers
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Stylists;
    using BeGorgeous.Web.ViewModels.Stylists;
    using Microsoft.AspNetCore.Mvc;

    public class StylistsController : BaseController
    {
        private readonly IStylistsService stylistsService;

        public StylistsController(IStylistsService stylistsService)
        {
            this.stylistsService = stylistsService;
        }

        public async Task<IActionResult> Team(int salonId)
        {
            var viewModel = new StylistsListViewModel
            {
                Stylists = await this.stylistsService.GetByIdAsync<StylistViewModel>(salonId),
            };

            return this.View(viewModel);
        }
    }
}
