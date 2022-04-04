namespace BeGorgeous.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Data.Appointments;
    using BeGorgeous.Services.Data.Salons;
    using BeGorgeous.Services.Data.SalonsTreatments;
    using BeGorgeous.Services.DateTimeParser;
    using BeGorgeous.Web.ViewModels.Appointments;
    using BeGorgeous.Web.ViewModels.Salons;
    using BeGorgeous.Web.ViewModels.Treatments;
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

        public async Task<IActionResult> BookAppointment(int salonId, int treatmentId)
        {
            var salonTreatment = await this.salonsTreatmentsService.GetSalonAndTreatmentByIdAsync<SalonsTreatmentsViewModel>(salonId, treatmentId);

            if (salonTreatment == null)
            {
                return this.View("UnavailableService");
            }

            var viewModel = new AppointmentInputModel
            {
                SalonId = salonId,
                TreatmentId = treatmentId,
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> MakeAnAppointment(AppointmentInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction("MakeAnAppointment", new { input.SalonId, input.TreatmentId });
            }

            DateTime dateTime;

            try
            {
                dateTime = this.dateTimeParserService.ConvertStrings(input.Date, input.Time);
            }
            catch (System.Exception)
            {
                return this.RedirectToAction("MakeAnAppointment", new { input.SalonId, input.TreatmentId });
            }

            var user = await this.userManager.GetUserAsync(this.HttpContext.User);
            var userId = await this.userManager.GetUserIdAsync(user);

            await this.appointmentsService.AddAsync(userId, input.SalonId, input.TreatmentId, dateTime);

            return this.RedirectToAction("Index");
        }

        public async Task<IActionResult> CancelAppointment(string id)
        {
            var viewModel = await this.appointmentsService.GetAppointmentByIdAsync<AppointmentViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAppointment(string id)
        {
            await this.appointmentsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }

        public async Task<IActionResult> RatePastAppointment(string id)
        {
            var viewModel = await this.appointmentsService.GetAppointmentByIdAsync<RatingAppointmentsViewModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RateSalon(RatingAppointmentsViewModel rating)
        {
            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction("RatePastAppointment", new { id = rating.Id });
            }

            if (rating.IsSalonRatedByTheUser == true)
            {
                return this.RedirectToAction("RatePastAppointment", new { id = rating.Id });
            }

            await this.appointmentsService.RateAppointmentAsync(rating.Id);

            await this.salonsService.RateSalonAsync(rating.SalonId, rating.RateValue);

            return this.RedirectToAction("Details", "Salons", new { id = rating.SalonId });
        }
    }
}
