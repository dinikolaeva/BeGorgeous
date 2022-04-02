namespace BeGorgeous.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Salons;
    using BeGorgeous.Web.ViewModels.Appointments;
    using Microsoft.AspNetCore.Mvc;

    public class SalonsTreatmentsDetailsViewComponent : ViewComponent
    {
        private readonly ISalonsService salonsService;

        public SalonsTreatmentsDetailsViewComponent(ISalonsService salonsService)
        {
            this.salonsService = salonsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int salonId)
        {
            var viewModel =
                await this.salonsService.GetByIdAsync<AppointmentSalonViewModel>(salonId);

            return this.View(viewModel);
        }
    }
}
