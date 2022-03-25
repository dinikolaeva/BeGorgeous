namespace BeGorgeous.Web.Controllers
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Treatments;
    using BeGorgeous.Web.ViewModels.SalonsTreatments;
    using BeGorgeous.Web.ViewModels.Treatments;
    using Microsoft.AspNetCore.Mvc;

    public class TreatmentsController : BaseController
    {
        private readonly ITreatmentsService treatmentsService;

        public TreatmentsController(ITreatmentsService treatmentsService)
        {
            this.treatmentsService = treatmentsService;
        }

        public async Task<IActionResult> All(int salonId)
        {
            var viewModel = new SalonsTreatmentsViewModel
            {
            };

            return this.View(viewModel);
        }
    }
}
