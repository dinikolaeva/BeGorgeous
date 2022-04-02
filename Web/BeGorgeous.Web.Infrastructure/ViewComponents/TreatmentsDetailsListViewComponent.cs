namespace BeGorgeous.Web.Infrastructure.ViewComponents
{
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.SalonsTreatments;
    using BeGorgeous.Web.ViewModels.Appointments;
    using BeGorgeous.Web.ViewModels.SalonsTreatments;
    using BeGorgeous.Web.ViewModels.Treatments;
    using Microsoft.AspNetCore.Mvc;

    public class TreatmentsDetailsListViewComponent : ViewComponent
    {
        private readonly ISalonsTreatmentsService salonsTreatmentsService;

        public TreatmentsDetailsListViewComponent(ISalonsTreatmentsService salonsTreatmentsService)
        {
            this.salonsTreatmentsService = salonsTreatmentsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var salon = await this.salonsTreatmentsService.GetByIdAsync<SalonsTreatmentsViewModel>(id);

            var treatmentsIds = salon.Select(t => t.TreatmentId).ToList();

            var viewModel = new AppointmentTreatmentsListViewModel
            {
                Treatments = await this.salonsTreatmentsService.GetAllByIdsAsync<AppointmentTreatmentsViewModel>(treatmentsIds),
            };

            return this.View(viewModel);
        }
    }
}
