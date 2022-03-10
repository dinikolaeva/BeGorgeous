namespace BeGorgeous.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Common.Models;

    public class Stylist : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.NameMaxLength)]

        public string FullName { get; set; }

        public string SalonId { get; set; }

        public Salon Salon { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [MaxLength(GlobalConstants.StringLengthValidations.ShortAutobiographyMaxLength)]
        public string ShortAutobiography { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public ICollection<Treatment> Treatments { get; set; } = new HashSet<Treatment>();

        public ICollection<Appointment> Appointment { get; set; } = new HashSet<Appointment>();
    }
}
