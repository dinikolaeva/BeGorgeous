namespace BeGorgeous.Data.Models
{
    using System.Collections.Generic;

    using BeGorgeous.Data.Common.Models;

    public class SalonTreatment : BaseDeletableModel<int>
    {
        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int TreatmentId { get; set; }

        public virtual Treatment Treatment { get; set; }
    }
}
