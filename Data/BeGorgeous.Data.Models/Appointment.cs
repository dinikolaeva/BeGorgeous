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

        public bool? Confirmed { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }
    }
}
