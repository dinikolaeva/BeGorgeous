namespace BeGorgeous.Services.Data.Tests.UseInMemoryDatabase
{
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Data.Categories;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class CategoriesServiceTests : BaseServiceTests
    {
        private ICategoriesService Service => this.ServiceProvider.GetRequiredService<ICategoriesService>();

        // TODO: test Task<IEnumerable<T>> GetAllAsync<T>()

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            await this.CreateCategoryAsync();

            var name = new NLipsum.Core.Word().ToString();

            await this.Service.AddAsync(name, "Some description Some description Some description", "someImageUrl");

            var categoriesCount = await this.DbContext.Categories.CountAsync();

            Assert.Equal(2, categoriesCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var category = await this.CreateCategoryAsync();

            await this.Service.DeleteAsync(category.Id);

            var countriesCount = this.DbContext.Countries
                                               .Where(x => !x.IsDeleted)
                                               .ToArray()
                                               .Count();

            var deletedCountry = await this.DbContext.Countries
                                                     .FirstOrDefaultAsync(x => x.Id == category.Id);

            Assert.Equal(0, countriesCount);
            Assert.Null(deletedCountry);
        }

        private async Task<Category> CreateCategoryAsync()
        {
            var category = new Category
            {
                Name = new NLipsum.Core.Word().ToString(),
                Description = new NLipsum.Core.Sentence().ToString(),
                ImageUrl = new NLipsum.Core.Sentence().ToString(),
            };

            await this.DbContext.Categories.AddAsync(category);

            await this.DbContext.SaveChangesAsync();

            this.DbContext.Entry<Category>(category).State = EntityState.Detached;

            return category;
        }
    }
}