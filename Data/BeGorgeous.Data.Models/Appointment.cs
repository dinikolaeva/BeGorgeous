namespace BeGorgeous.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Data.Common.Models;

    public class Appointment : BaseDeletableModel<string>
    {
        public DateTime DateTime { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public int SalonId { get; set; }

        public Salon Salon { get; set; }

        // The salon can confirm or decline an appointment
        public bool? Confirmed { get; set; }

        // For every past (and confirmed) appointment the User can Rate the Salon
        // But rating can be given only once for each appointment
        public bool? IsSalonRatedByTheUser { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; } = new HashSet<Treatment>();
    }
}
