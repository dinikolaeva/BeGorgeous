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

        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [MaxLength(GlobalConstants.StringLengthValidations.ShortAutobiographyMaxLength)]
        public string ShortAutobiography { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public virtual ICollection<StylistTreatment> Treatments { get; set; } = new HashSet<StylistTreatment>();
    }
}
