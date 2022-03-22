namespace BeGorgeous.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Common.Models;

    public class Treatment : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        public decimal Price { get; set; }
    }
}
