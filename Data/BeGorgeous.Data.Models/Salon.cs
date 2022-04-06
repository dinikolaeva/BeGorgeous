namespace BeGorgeous.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Common.Models;

    public class Salon : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.Name)]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.AddressMaxLength)]
        public string StreetAddress { get; set; }

        [Required]
        [RegularExpression(GlobalConstants.RegularExpretions.PhoneNUmber)]
        public string PhoneNumber { get; set; }

        public double Rating { get; set; }

        public int RatersCount { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string StreetMapUrl { get; set; }

        public virtual ICollection<Stylist> Stylists { get; set; } = new HashSet<Stylist>();

        public virtual ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();

        public virtual ICollection<CategorySalon> CategoriesSalons { get; set; } = new HashSet<CategorySalon>();

        public virtual ICollection<SalonTreatment> SalonsTreatments { get; set; } = new HashSet<SalonTreatment>();
    }
}
