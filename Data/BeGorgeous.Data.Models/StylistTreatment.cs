namespace BeGorgeous.Data.Models
{
    using BeGorgeous.Data.Common.Models;

    public class StylistTreatment : BaseDeletableModel<int>
    {
        public int StylistId { get; set; }

        public virtual Stylist Stylist { get; set; }

        public int? TreatmentId { get; set; }

        public virtual Treatment Treatment { get; set; }
    }
}
