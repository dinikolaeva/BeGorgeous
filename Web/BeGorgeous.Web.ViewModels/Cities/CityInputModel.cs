namespace BeGorgeous.Web.ViewModels.Cities
{
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;

    public class CityInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.StringLengthValidations.Name,
            MinimumLength = GlobalConstants.StringLengthValidations.NameMinLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Name)]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}
