namespace BeGorgeous.Services.Data.Tests.UseInMemoryDatabase
{
    using System;

    using BeGorgeous.Data;
    using BeGorgeous.Data.Common.Repositories;
    using BeGorgeous.Data.Repositories;
    using BeGorgeous.Services.Data.Appointments;
    using BeGorgeous.Services.Data.Categories;
    using BeGorgeous.Services.Data.Cities;
    using BeGorgeous.Services.Data.Countries;
    using BeGorgeous.Services.Data.Salons;
    using BeGorgeous.Services.Data.SalonsTreatments;
    using BeGorgeous.Services.Data.Stylists;
    using BeGorgeous.Services.Data.Treatments;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public abstract class BaseServiceTests : IDisposable
    {
        protected BaseServiceTests()
        {
            var services = this.SetServices();

            this.ServiceProvider = services.BuildServiceProvider();
            this.DbContext = this.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        }

        protected IServiceProvider ServiceProvider { get; set; }

        protected ApplicationDbContext DbContext { get; set; }

        public void Dispose()
        {
            this.DbContext.Database.EnsureDeleted();
            this.SetServices();
        }

        private ServiceCollection SetServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(
                options => options.UseInMemoryDatabase(Guid.NewGuid().ToString()));

            // Data repositories
            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            // Application services
            services.AddTransient<ICountriesService, CountriesService>();
            services.AddTransient<ICitiesService, CitiesService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<ITreatmentsService, TreatmentsService>();
            services.AddTransient<ISalonsService, SalonsService>();
            services.AddTransient<IStylistsService, StylistsService>();
            services.AddTransient<ISalonsTreatmentsService, SalonsTreatmentsService>();
            services.AddTransient<IAppointmentsService, AppointmentsService>();

            return services;
        }
    }
}
