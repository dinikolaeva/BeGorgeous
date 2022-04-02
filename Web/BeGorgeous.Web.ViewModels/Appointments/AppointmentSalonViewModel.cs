namespace BeGorgeous.Web.ViewModels.Appointments
{
    using System.Collections.Generic;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class AppointmentSalonViewModel : IMapFrom<Salon>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual City City { get; set; }

        public string StreetAddress { get; set; }

        public ICollection<SalonTreatment> SalonsTreatments { get; set; }
    }
}
