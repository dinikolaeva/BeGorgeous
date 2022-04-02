namespace BeGorgeous.Web.ViewModels.Appointments
{
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Web.ViewModels.Common;
    using BeGorgeous.Web.ViewModels.Common.CustomValidationAttributes;

    public class AppointmentInputModel
    {
        [Required]
        public int SalonId { get; set; }

        [Required]
        public int TreatmentId { get; set; }

        [Required]
        public int StylistId { get; set; }

        [Required]
        [ValidateDateString(ErrorMessage = GlobalConstants.ErrorMessages.DateTime)]
        public string Date { get; set; }

        [Required]
        [ValidateTimeString(ErrorMessage = GlobalConstants.ErrorMessages.DateTime)]
        public string Time { get; set; }
    }
}
