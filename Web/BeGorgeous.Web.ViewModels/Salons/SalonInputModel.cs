namespace BeGorgeous.Web.ViewModels.Salons
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Web.ViewModels.Common.CustomValidationAttributes;
    using BeGorgeous.Web.ViewModels.Common.SelectedLists;
    using Microsoft.AspNetCore.Http;

    public class SalonInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.Name,
            MinimumLength = GlobalConstants.StringLengthValidations.NameMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Name)]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.DescriptionMaxLength,
            MinimumLength = GlobalConstants.StringLengthValidations.DescriptionMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Description)]
        public string Description { get; set; }

        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.AddressMaxLength,
            MinimumLength = GlobalConstants.StringLengthValidations.AddressMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Address)]
        public string StreetAddress { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = GlobalConstants.ErrorMessages.Image)]
        public IFormFile Image { get; set; }

        [Required]
        [RegularExpression(
            GlobalConstants.RegularExpretions.PhoneNUmber,
            ErrorMessage = GlobalConstants.ErrorMessages.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [Url(ErrorMessage = GlobalConstants.ErrorMessages.Url)]
        public string StreetMapUrl { get; set; }

        [Required]
        public List<int> TreatmentsIds { get; set; } = new List<int>();

        public List<TreatmentsSelectListViewModel> Treatments { get; set; } =
            new List<TreatmentsSelectListViewModel>();
    }
}
