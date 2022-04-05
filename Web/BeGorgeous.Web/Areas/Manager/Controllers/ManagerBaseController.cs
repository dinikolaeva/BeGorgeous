namespace BeGorgeous.Web.Areas.Menager.Controllers
{
    using BeGorgeous.Common;
    using BeGorgeous.Web.Controllers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.ManagerRoleName)]
    [Area("Manager")]
    public class ManagerBaseController : BaseController
    {
    }
}
