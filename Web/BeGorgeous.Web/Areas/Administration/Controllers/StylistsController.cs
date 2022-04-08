namespace BeGorgeous.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;
    using BeGorgeous.Common;
    using BeGorgeous.Services.Cloudinary;
    using BeGorgeous.Services.Data.Categories;
    using BeGorgeous.Services.Data.Salons;
    using BeGorgeous.Services.Data.Stylists;
    using BeGorgeous.Web.ViewModels.Common.SelectedLists;
    using BeGorgeous.Web.ViewModels.Stylists;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class StylistsController : AdministrationController
    {
        private readonly IStylistsService stylistsService;
        private readonly ICategoriesService categoriesService;
        private readonly ISalonsService salonsService;
        private readonly ICloudinaryService cloudinaryService;

        public StylistsController(
            IStylistsService stylistsService,
            ICategoriesService categoriesService,
            ISalonsService salonsService,
            ICloudinaryService cloudinaryService)
        {
            this.stylistsService = stylistsService;
            this.categoriesService = categoriesService;
            this.salonsService = salonsService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new StylistsListViewModel
            {
                Stylists = await this.stylistsService.GetAllAsync<StylistViewModel>(),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> AddStylist()
        {
            var salons = await this.salonsService.GetAllAsync<SalonsSelectListViewModel>();
            var categories = await this.categoriesService.GetAllAsync<CategoriesSelectListViewModel>();

            this.ViewData["Salons"] = new SelectList(salons, "Id", "Name");
            this.ViewData["Categories"] = new SelectList(categories, "Id", "Name");

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStylist(StylistInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string imageUrl;

            try
            {
                imageUrl = await this.cloudinaryService.UploadPictureAsync(input.ImageUrl, input.FullName);
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                imageUrl = GlobalConstants.Images.MissingUploadImage;
            }

            await this.stylistsService.AddAsync(input.FullName, input.SalonId, input.CategoryId, input.ShortAutobiography, imageUrl);

            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteStylist(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Stylists)
            {
                return this.RedirectToAction("Index");
            }

            await this.stylistsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
