namespace BeGorgeous.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using BeGorgeous.Web.ViewModels.Categories;

    public class IndexViewModel
    {
        public IEnumerable<IndexCountryViewModel> Countries { get; set; }
    }
}
