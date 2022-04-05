namespace BeGorgeous.Web.Areas.Menager.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : ManagerBaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
