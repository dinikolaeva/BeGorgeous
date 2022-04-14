namespace BeGorgeous.Services.Data.Tests.UseInMemoryDatabase.ControllersTests
{
    using BeGorgeous.Web.Controllers;
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class HomeControllerTest
    {
        [Fact]
        public void HomeControllerShouldReturnViewForError404()
        {
            var homeController = new HomeController(null, null);

            var result = homeController.Error404();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void HomeControllerShouldReturnViewForPrivacy()
        {
            var homeController = new HomeController(null, null);

            var result = homeController.Privacy();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
    }
}
