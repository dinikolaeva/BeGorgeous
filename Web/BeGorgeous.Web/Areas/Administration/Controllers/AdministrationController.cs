namespace BeGorgeous.Web.Areas.Administration.Controllers
{
    using BeGorgeous.Common;
    using BeGorgeous.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
