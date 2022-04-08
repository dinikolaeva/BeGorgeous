namespace BeGorgeous.Web.ViewModels.Stylists
{
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Web.ViewModels.Common.CustomValidationAttributes;
    using Microsoft.AspNetCore.Http;

    public class StylistInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.NameMaxLength,
            MinimumLength = GlobalConstants.StringLengthValidations.NameMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.StylistName)]
        public string FullName { get; set; }

        [Required]
        public int SalonId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.ShortAutobiographyMaxLength,
            MinimumLength = GlobalConstants.StringLengthValidations.ShortAutobiographyMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.ShortAutobiography)]
        public string ShortAutobiography { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = GlobalConstants.ErrorMessages.Image)]
        public IFormFile ImageUrl { get; set; }
    }
}
