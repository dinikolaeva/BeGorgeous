namespace BeGorgeous.Web.Controllers
{
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
                                             .GetByIdAsync<SalonsTreatmentsViewModel>(salonId);

            var treatmentsIds = salonTreatments.Select(i => i.TreatmentId).ToList();

            var viewModel = new TreatmentsListViewModel
            {
                Treatments = await this.salonsTreatmentsService.GetAllByIdsAsync<TreatmentViewModel>(treatmentsIds),
            };

            return this.View(viewModel);
        }
    }
}
