namespace BeGorgeous.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;
    using BeGorgeous.Common;
    using BeGorgeous.Services.Cloudinary;
    using BeGorgeous.Services.Data.Categories;
    using BeGorgeous.Services.Data.Treatments;
    using BeGorgeous.Web.ViewModels.Common.SelectedLists;
    using BeGorgeous.Web.ViewModels.Treatments;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class TreatmentsController : AdministrationController
    {
        private readonly ITreatmentsService treatmentsService;
        private readonly ICategoriesService categoriesService;
        private readonly ICloudinaryService cloudinaryService;

        public TreatmentsController(
            ITreatmentsService treatmentsService,
            ICategoriesService categoriesService,
            ICloudinaryService cloudinaryService)
        {
            this.treatmentsService = treatmentsService;
            this.categoriesService = categoriesService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new TreatmentsListViewModel
            {
                Treatments = await this.treatmentsService.GetAllAsync<TreatmentViewModel>(),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> AddTreatment()
        {
            var categories = await this.categoriesService.GetAllAsync<CategoriesSelectListViewModel>();

            this.ViewData["Categories"] = new SelectList(categories, "Id", "Name");

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTreatment(TreatmentInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string imageUrl;
            try
            {
                imageUrl = await this.cloudinaryService.UploadPictureAsync(input.ImageUrl, input.Name);
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                imageUrl = GlobalConstants.Images.MissingUploadImage;
            }

            string iconUrl;
            try
            {
                iconUrl = await this.cloudinaryService.UploadPictureAsync(input.IconUrl, input.Name);
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                iconUrl = GlobalConstants.Images.MissingUploadImage;
            }

            await this.treatmentsService.AddAsync(input.Name, input.CategoryId, input.Description, imageUrl, iconUrl, input.Duration, input.Price);

            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTreatment(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Treatments)
            {
                return this.RedirectToAction("Index");
            }

            await this.treatmentsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
