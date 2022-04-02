namespace BeGorgeous.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.SalonsTreatments;
    using BeGorgeous.Web.ViewModels.SalonsTreatments;
    using BeGorgeous.Web.ViewModels.Treatments;
    using Microsoft.AspNetCore.Mvc;

    public class TreatmentsController : BaseController
    {
        private readonly ISalonsTreatmentsService salonsTreatmentsService;

        public TreatmentsController(ISalonsTreatmentsService salonsTreatmentsService)
        {
            this.salonsTreatmentsService = salonsTreatmentsService;
        }

        public async Task<IActionResult> All(int salonId)
        {
            var salonTreatments = await this.salonsTreatmentsService
                                            .GetByIdAsync<SalonsTreatmentsSimpleViewModel>(salonId);

            var treatmentsIds = salonTreatments.Select(i => i.TreatmentId).ToList();

            if (!this.salonsTreatmentsService.IsSalonIdValid(salonId))
            {
                return this.View("UnavailableService");
            }

            var viewModel = new TreatmentsListViewModel
            {
                SalonId = salonId,
                Treatments = await this.salonsTreatmentsService.GetAllByIdsAsync<TreatmentViewModel>(treatmentsIds),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> Details(int salonId, int treatmentId)
        {
            if (!this.salonsTreatmentsService.IsTreatmentAndSalonIdValid(salonId, treatmentId))
            {
                return this.View("UnavailableService");
            }

            var viewModel = await this.salonsTreatmentsService.GetSalonAndTreatmentByIdAsync<SalonsTreatmentsViewModel>(salonId, treatmentId);

            return this.View(viewModel);
        }
    }
}
