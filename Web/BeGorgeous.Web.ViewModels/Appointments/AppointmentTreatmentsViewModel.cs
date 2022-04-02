namespace BeGorgeous.Web.ViewModels.Treatments
{
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class AppointmentTreatmentsViewModel : IMapFrom<Treatment>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Category Category { get; set; }
    }
}
