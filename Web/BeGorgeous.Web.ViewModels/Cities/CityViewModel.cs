namespace BeGorgeous.Web.ViewModels.Cities
{
    using System.Collections.Generic;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;

    public class CityViewModel : IMapFrom<City>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public virtual ICollection<Salon> Salons { get; set; }
    }
}
