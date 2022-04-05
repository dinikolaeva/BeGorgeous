namespace BeGorgeous.Web.Areas.Manager.Controllers
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Appointments;
    using BeGorgeous.Services.Data.Salons;
    using BeGorgeous.Web.Areas.Menager.Controllers;
    using BeGorgeous.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsController : ManagerBaseController
    {
        private readonly ISalonsService salonsService;
        private readonly IAppointmentsService appointmentsService;

        public SalonsController(ISalonsService salonsService, IAppointmentsService appointmentsService)
        {
            this.salonsService = salonsService;
            this.appointmentsService = appointmentsService;
        }

        public async Task<IActionResult> Details(int id)
        {
            var viewModel = await this.salonsService.GetByIdAsync<SalonWithStylistsAndTreatmentsViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmAppointment(string id, int salonId)
        {
            await this.appointmentsService.ConfirmAsync(id);

            return this.RedirectToAction("Details", new { id = salonId });
        }

        [HttpPost]
        public async Task<IActionResult> DeclineAppointment(string id, string salonId)
        {
            await this.appointmentsService.DeclineAsync(id);

            return this.RedirectToAction("Details", new { id = salonId });
        }
    }
}
