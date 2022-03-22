﻿namespace BeGorgeous.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Common.Models;

    public class City : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.AddressMaxLength)]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public ICollection<Salon> Salons { get; set; } = new HashSet<Salon>();
    }
}
