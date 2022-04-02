namespace BeGorgeous.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Salons;
    using BeGorgeous.Services.Data.SalonsTreatments;
    using BeGorgeous.Web.ViewModels.Appointments;
    using BeGorgeous.Web.ViewModels.SalonsTreatments;
    using BeGorgeous.Web.ViewModels.Treatments;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsTreatmentsDetailsViewComponent : ViewComponent
    {
        private readonly ISalonsTreatmentsService salonsTreatmentsService;

        public SalonsTreatmentsDetailsViewComponent(ISalonsTreatmentsService salonsTreatmentsService)
        {
            this.salonsTreatmentsService = salonsTreatmentsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int salonId, int treatmentId)
        {
            var viewModel =
                await this.salonsTreatmentsService.GetSalonAndTreatmentByIdAsync<SalonsTreatmentsViewModel>(salonId, treatmentId);

            return this.View(viewModel);
        }
    }
}
