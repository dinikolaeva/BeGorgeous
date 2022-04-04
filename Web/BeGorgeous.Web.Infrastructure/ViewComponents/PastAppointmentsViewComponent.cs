namespace BeGorgeous.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Data.Appointments;
    using BeGorgeous.Web.ViewModels.Appointments;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class PastAppointmentsViewComponent : ViewComponent
    {
        private readonly IAppointmentsService appointmentsService;
        private readonly UserManager<ApplicationUser> userManager;

        public PastAppointmentsViewComponent(
            IAppointmentsService appointmentsService,
            UserManager<ApplicationUser> userManager)
        {
            this.appointmentsService = appointmentsService;
            this.userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await this.userManager.GetUserAsync(this.HttpContext.User);
            var userId = await this.userManager.GetUserIdAsync(user);

            var viewModel = new AppointmentsListViewModel
            {
                Appointments =
                    await this.appointmentsService.GetPastAppointmentsOfUserAsync<AppointmentViewModel>(userId),
            };

            return this.View(viewModel);
        }
    }
}
