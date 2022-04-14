namespace BeGorgeous.Services.Data.Tests.UseInMemoryDatabase
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Data.Treatments;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class TreatmentsServiceTests : BaseServiceTests
    {
        // TODO: Task<IEnumerable<T>> GetAllAsync<T>();

        private ITreatmentsService Service => this.ServiceProvider.GetRequiredService<ITreatmentsService>();

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            await this.CreateTreatmentAsync();

            var name = new NLipsum.Core.Sentence().ToString();
            var categoryId = 1;
            var description = new NLipsum.Core.Paragraph().ToString();
            var imageUrl = new NLipsum.Core.Word().ToString();
            var iconUrl = new NLipsum.Core.Word().ToString();
            var duration = TimeSpan.FromMinutes(50);
            var price = 50.00M;

            await this.Service.AddAsync(name, categoryId, description, imageUrl, iconUrl, duration, price);

            var treatmentsCount = await this.DbContext.Treatments.CountAsync();

            Assert.Equal(2, treatmentsCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var treatment = await this.CreateTreatmentAsync();

            await this.Service.DeleteAsync(treatment.Id);

            var treatmentsCount = this.DbContext.Treatments
                                                .Where(x => !x.IsDeleted)
                                                .ToArray()
                                                .Count();

            var deletedService = await this.DbContext.Treatments
                                                     .FirstOrDefaultAsync(x => x.Id == treatment.Id);

            Assert.Equal(0, treatmentsCount);

            Assert.Null(deletedService);
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
    }
}
