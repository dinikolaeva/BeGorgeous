namespace BeGorgeous.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Common.Models;

    public class Country : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.AddressMaxLength)]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; } = new HashSet<City>();

        public ICollection<Salon> Salons { get; set; } = new HashSet<Salon>();
    }
}
