namespace BeGorgeous.Web.ViewModels.Appointments
{
    using System;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class AppointmentViewModel : IMapFrom<Appointment>
    {
        public string Id { get; set; }

        public DateTime DateTime { get; set; }

        public string UserEmail { get; set; }

        public string SalonId { get; set; }

        public Salon Salon { get; set; }

        public int TreatmentId { get; set; }

        public string TreatmentName { get; set; }

        public bool? Confirmed { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }
    }
}
