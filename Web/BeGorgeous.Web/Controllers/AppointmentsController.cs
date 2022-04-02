namespace BeGorgeous.Web.Controllers
{
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Data.Appointments;
    using BeGorgeous.Services.Data.Salons;
    using BeGorgeous.Services.Data.SalonsTreatments;
    using BeGorgeous.Services.DateTimeParser;
    using BeGorgeous.Web.ViewModels.Appointments;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class AppointmentsController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IAppointmentsService appointmentsService;
        private readonly ISalonsTreatmentsService salonsTreatmentsService;
        private readonly IDateTimeParserService dateTimeParserService;
        private readonly ISalonsService salonsService;

        public AppointmentsController(
            UserManager<ApplicationUser> userManager,
            IAppointmentsService appointmentsService,
            ISalonsTreatmentsService salonsTreatmentsService,
            IDateTimeParserService dateTimeParserService,
            ISalonsService salonsService)
        {
            this.userManager = userManager;
            this.appointmentsService = appointmentsService;
            this.salonsTreatmentsService = salonsTreatmentsService;
            this.dateTimeParserService = dateTimeParserService;
            this.salonsService = salonsService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await this.userManager.GetUserAsync(this.HttpContext.User);
            var userId = await this.userManager.GetUserIdAsync(user);

            var viewModel = new AppointmentsListViewModel
            {
                Appointments =
                await this.appointmentsService.GetUpcomingByUserAsync<AppointmentViewModel>(userId),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> BookAppointment(int salonId)
        {
            var salon = await this.salonsService.GetByIdAsync<AppointmentSalonViewModel>(salonId);

            if (salon == null)
            {
                return this.View("UnavailableService");
            }

            var viewModel = new AppointmentInputModel
            {
                SalonId = salon.Id,
            };

            return this.View(viewModel);
        }
    }
}
