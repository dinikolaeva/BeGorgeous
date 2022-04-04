namespace BeGorgeous.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Data.Common.Models;

    public class Appointment : BaseDeletableModel<string>
    {
        public DateTime DateTime { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int TreatmentId { get; set; }

        public virtual Treatment Treatment { get; set; }

        // The salon can confirm or decline an appointment
        public bool? Confirmed { get; set; }

        // For every past (and confirmed) appointment the User can Rate the Salon
        // But rating can be given only once for each appointment
        public bool? IsSalonRatedByTheUser { get; set; }
    }
}
