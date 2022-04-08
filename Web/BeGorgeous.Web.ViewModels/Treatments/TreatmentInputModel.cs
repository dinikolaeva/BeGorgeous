namespace BeGorgeous.Web.ViewModels.Treatments
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Web.ViewModels.Common.CustomValidationAttributes;
    using Microsoft.AspNetCore.Http;

    public class TreatmentInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.Name,
            MinimumLength = GlobalConstants.StringLengthValidations.NameMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Name)]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.DescriptionMaxLength,
            MinimumLength = GlobalConstants.StringLengthValidations.DescriptionMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Description)]
        public string Description { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = GlobalConstants.ErrorMessages.Image)]
        public IFormFile ImageUrl { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = GlobalConstants.ErrorMessages.Image)]
        public IFormFile IconUrl { get; set; }

        [RegularExpression(
            GlobalConstants.RegularExpretions.Duration,
            ErrorMessage = GlobalConstants.ErrorMessages.Duration)]
        public TimeSpan Duration { get; set; }

        [Required]
        [RegularExpression(
            GlobalConstants.RegularExpretions.Price,
            ErrorMessage = GlobalConstants.ErrorMessages.Price)]
        public decimal Price { get; set; }
    }
}
