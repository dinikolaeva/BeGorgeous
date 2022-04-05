namespace BeGorgeous.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeGorgeous.Services.Data.Appointments;
    using BeGorgeous.Web.ViewModels.Appointments;
    using Microsoft.AspNetCore.Mvc;

    public class AllAppointmentsBySalonViewComponent : ViewComponent
    {
        private readonly IAppointmentsService appointmentsService;

        public AllAppointmentsBySalonViewComponent(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int salonId)
        {
            var viewModel = new AppointmentsListViewModel
            {
                Appointments =
                    await this.appointmentsService.GetAllAppointmentsBySalonAsync<AppointmentViewModel>(salonId),
            };

            return this.View(viewModel);
        }
    }
}
