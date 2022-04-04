namespace BeGorgeous.Web.ViewModels.Appointments
{
    using System.ComponentModel.DataAnnotations;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class RatingAppointmentsViewModel : IMapFrom<Appointment>
    {
        public string Id { get; set; }

        public int SalonId { get; set; }

        public Salon Salon { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = GlobalConstants.ErrorMessages.Rating)]
        public int RateValue { get; set; }
    }
}
