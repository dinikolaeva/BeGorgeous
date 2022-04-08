namespace BeGorgeous.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Services.Cloudinary;
    using BeGorgeous.Services.Data.Cities;
    using BeGorgeous.Services.Data.Countries;
    using BeGorgeous.Services.Data.Salons;
    using BeGorgeous.Services.Data.SalonsTreatments;
    using BeGorgeous.Services.Data.Treatments;
    using BeGorgeous.Web.ViewModels.Common.SelectedLists;
    using BeGorgeous.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class SalonsController : AdministrationController
    {
        private readonly ISalonsService salonsService;
        private readonly ICountriesService countriesService;
        private readonly ICitiesService citiesService;
        private readonly ICloudinaryService cloudinaryService;
        private readonly ITreatmentsService treatmentsService;
        private readonly ISalonsTreatmentsService salonsTreatmentsService;

        public SalonsController(
            ISalonsService salonsService,
            ICountriesService countriesService,
            ICitiesService citiesService,
            ICloudinaryService cloudinaryService,
            ITreatmentsService treatmentsService,
            ISalonsTreatmentsService salonsTreatmentsService)
        {
            this.salonsService = salonsService;
            this.countriesService = countriesService;
            this.citiesService = citiesService;
            this.cloudinaryService = cloudinaryService;
            this.treatmentsService = treatmentsService;
            this.salonsTreatmentsService = salonsTreatmentsService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new SalonsListViewModel
            {
                Salons = await this.salonsService.GetAllAsync<SalonViewModel>(),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> AddSalon()
        {
            var countries = await this.countriesService.GetAllAsync<CountriesSelectListViewModel>();
            var cities = await this.citiesService.GetAllAsync<CitiesSelectListViewModel>();
            var treatments = await this.treatmentsService.GetAllAsync<TreatmentsSelectListViewModel>();

            this.ViewData["Countries"] = new SelectList(countries, "Id", "Name");
            this.ViewData["Cities"] = new SelectList(cities, "Id", "Name");

            // Treatments may be selected with Ctrl + mouseClick
            this.ViewData["Treatments"] = new SelectList(treatments, "Id", "Name");

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSalon(SalonInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string imageUrl;
            try
            {
                imageUrl = await this.cloudinaryService.UploadPictureAsync(input.Image, input.Name);
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                imageUrl = GlobalConstants.Images.MissingUploadImage;
            }

            // Add Salon
            var salonId = await this.salonsService.AddAsync(input.Name, input.CountryId, input.CityId, input.Description, input.StreetAddress, imageUrl, input.PhoneNumber, input.StreetMapUrl);

            // Get treatments
            var treatmentsIds = input.TreatmentsIds;

            // Add Salon with selected treatments
            await this.salonsTreatmentsService.AddAsync(salonId, treatmentsIds);

            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSalon(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Salons)
            {
                return this.RedirectToAction("Index");
            }

            await this.salonsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
