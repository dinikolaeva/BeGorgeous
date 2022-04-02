namespace BeGorgeous.Web.ViewModels.Treatments
{
    using System.Collections.Generic;

    public class TreatmentsListViewModel
    {
        public int SalonId { get; set; }

        public IEnumerable<TreatmentViewModel> Treatments { get; set; }
    }
}
