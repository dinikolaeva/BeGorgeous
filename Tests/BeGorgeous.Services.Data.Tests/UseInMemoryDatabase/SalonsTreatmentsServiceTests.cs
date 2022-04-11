namespace BeGorgeous.Services.Data.Tests.UseInMemoryDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Data.SalonsTreatments;
    using BeGorgeous.Web.ViewModels.Treatments;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class SalonsTreatmentsServiceTests : BaseServiceTests
    {
        // TODO: Task<IEnumerable<T>> GetByIdAsync<T>(int salonId);

        // TODO: Task<IEnumerable<T>> GetAllByIdsAsync<T>(List<int> ids);

        // TODO: Task<T> GetTreatmentByIdAsync<T>(int treatmentId);

        // TODO: Task<T> GetSalonAndTreatmentByIdAsync<T>(int salonId, int treatmentId);

        private ISalonsTreatmentsService Service => this.ServiceProvider.GetRequiredService<ISalonsTreatmentsService>();

        // TODO: Task<T> GetSalonAndTreatmentByIdAsync<T>(int salonId, int treatmentId);

        //[Fact]
        //public async Task GetSalonAndTreatmentByIdAsyncWorkCorrectly()
        //{
        //    //var salon = await this.CreateSalonAsync();
        //    //var treatment = await this.CreateTreatmentAsync();
        //    //var treatment1 = await this.CreateTreatmentAsync();
        //    //var treatment2 = await this.CreateTreatmentAsync();

        //    //var treatmentsIds = new List<int> { treatment.Id, treatment1.Id, treatment2.Id };

        //    //await this.Service.AddAsync(salon.Id, treatmentsIds);

        //    AutoMapperConfig.RegisterMappings(typeof(SalonsTreatmentsViewModel).Assembly, typeof(SalonTreatment).Assembly);

        //    await this.CreateSalonTreatmentAsync(1, 2);

        //    var expect = this.DbContext.SalonsTreatments;

        //    var actual = 
        //        await this.Service.GetSalonAndTreatmentByIdAsync<SalonsTreatmentsViewModel>(1, 2);

        //    Assert.Equal(expect.ToQueryString(), actual.ToString());
        //}

        [Fact]
        public async Task AddAsyncShouldWorkCorrectlyWithManyTreatmentsAndOneSalon()
        {
            var salon = await this.CreateSalonAsync();
            var treatment = await this.CreateTreatmentAsync();
            var treatment1 = await this.CreateTreatmentAsync();
            var treatment2 = await this.CreateTreatmentAsync();

            var treatmentsIds = new List<int> { treatment.Id, treatment1.Id, treatment2.Id };

            await this.Service.AddAsync(salon.Id, treatmentsIds);

            var expected = 3;

            var actual = await this.DbContext.SalonsTreatments.CountAsync();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task IsSalonIdValidMustReturnTrueIfServiceHaveValidSalonId()
        {
            var salon = await this.CreateSalonAsync();
            var treatment = await this.CreateTreatmentAsync();
            var treatment1 = await this.CreateTreatmentAsync();
            var treatment2 = await this.CreateTreatmentAsync();

            var treatmentsIds = new List<int> { treatment.Id, treatment1.Id, treatment2.Id };

            await this.Service.AddAsync(salon.Id, treatmentsIds);

            var result = this.Service.IsSalonIdValid(salon.Id);

            Assert.True(result);
        }

        [Fact]
        public async Task IsTreatmentAndSalonIdValidMustReturnTrueIfServiceHaveValidSalonIdAndTreatmentId()
        {
            var salon = await this.CreateSalonAsync();
            var treatment = await this.CreateTreatmentAsync();
            var treatment1 = await this.CreateTreatmentAsync();
            var treatment2 = await this.CreateTreatmentAsync();

            var treatmentsIds = new List<int> { treatment.Id, treatment1.Id, treatment2.Id };

            await this.Service.AddAsync(salon.Id, treatmentsIds);

            var result = this.Service.IsTreatmentAndSalonIdValid(salon.Id, 2);

            Assert.True(result);
        }

        private async Task<Salon> CreateSalonAsync()
        {
            var salon = new Salon
            {
                Name = new NLipsum.Core.Sentence().ToString(),
                CityId = 1,
                CountryId = 1,
                StreetAddress = new NLipsum.Core.Sentence().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
                PhoneNumber = "123456789",
                StreetMapUrl = new NLipsum.Core.Word().ToString(),
                Description = new NLipsum.Core.Sentence().ToString(),
                Rating = 4,
                RatersCount = 1,
            };

            await this.DbContext.Salons.AddAsync(salon);

            await this.DbContext.SaveChangesAsync();

            this.DbContext.Entry<Salon>(salon).State = EntityState.Detached;

            return salon;
        }

        private async Task<Treatment> CreateTreatmentAsync()
        {
            var treatment = new Treatment
            {
                Name = new NLipsum.Core.Word().ToString(),
                CategoryId = 1,
                Description = new NLipsum.Core.Sentence().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
                IconUrl = new NLipsum.Core.Word().ToString(),
                Duration = TimeSpan.FromMinutes(50),
                Price = 50.00M,
            };

            await this.DbContext.Treatments.AddAsync(treatment);
            await this.DbContext.SaveChangesAsync();

            this.DbContext.Entry<Treatment>(treatment).State = EntityState.Detached;

            return treatment;
        }

        private async Task<SalonTreatment> CreateSalonTreatmentAsync(int salonId, int treatmentId)
        {
            var salonTreatment = new SalonTreatment
            {
                SalonId = salonId,
                TreatmentId = treatmentId,
            };

            await this.DbContext.SalonsTreatments.AddAsync(salonTreatment);
            await this.DbContext.SaveChangesAsync();

            this.DbContext.Entry<SalonTreatment>(salonTreatment).State = EntityState.Detached;

            return salonTreatment;
        }
    }
}
