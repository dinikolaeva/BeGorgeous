namespace BeGorgeous.Web.ViewModels.Appointments
{
    using System.Collections.Generic;

    using BeGorgeous.Web.ViewModels.Treatments;

    public class AppointmentTreatmentsListViewModel
    {
        public IEnumerable<AppointmentTreatmentsViewModel> Treatments { get; set; }
    }
}
