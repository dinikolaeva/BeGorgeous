namespace BeGorgeous.Web.ViewModels.Countries
{
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;

    public class CountryInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.Name,
            MinimumLength = GlobalConstants.StringLengthValidations.NameMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Name)]
        public string Name { get; set; }
    }
}
