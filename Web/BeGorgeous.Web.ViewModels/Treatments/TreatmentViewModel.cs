namespace BeGorgeous.Web.ViewModels.Treatments
{
    using System;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class TreatmentViewModel : IMapFrom<Treatment>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string IconUrl { get; set; }

        public TimeSpan Duration { get; set; }

        public decimal Price { get; set; }
    }
}
