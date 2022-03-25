namespace BeGorgeous.Data.Models
{
    using BeGorgeous.Data.Common.Models;

    public class CategorySalon : BaseDeletableModel<int>
    {
        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}
