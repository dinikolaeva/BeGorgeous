namespace BeGorgeous.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using BeGorgeous.Web.ViewModels.Cities;

    public class IndexViewModel
    {
        public IEnumerable<CityViewModel> Cities { get; set; }

        public IEnumerable<IndexCountryViewModel> Countries { get; set; }
    }
}
