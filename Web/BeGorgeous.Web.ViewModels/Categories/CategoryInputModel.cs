namespace BeGorgeous.Web.ViewModels.Categories
{
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Web.ViewModels.Common.CustomValidationAttributes;
    using Microsoft.AspNetCore.Http;

    public class CategoryInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.NameMaxLength,
            MinimumLength = GlobalConstants.StringLengthValidations.NameMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Name)]
        public string Name { get; set; }

        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.DescriptionMaxLength,
            MinimumLength = GlobalConstants.StringLengthValidations.DescriptionMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Description)]
        public string Description { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = GlobalConstants.ErrorMessages.Image)]
        public IFormFile Image { get; set; }
    }
}
