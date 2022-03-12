namespace BeGorgeous.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Common.Models;

    public class Salon : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.AddressMaxLength)]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.AddressMaxLength)]
        public string StreetAddress { get; set; }

        [Required]
        [RegularExpression(@"^\+?[0-9]{9,13}$", ErrorMessage = "Please enter valid phone number!")]
        public string PhoneNumber { get; set; }

        public double Rating { get; set; }

        public int RatersCount { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.DescriptionMaxLength)]

        //// every Salon has 'about us' information

        public string Description { get; set; }

        public virtual ICollection<Stylist> Stylists { get; set; } = new HashSet<Stylist>();

        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();

        public virtual ICollection<Treatment> Treatments { get; set; } = new HashSet<Treatment>();

        public virtual ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();
    }
}
