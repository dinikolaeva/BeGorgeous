namespace BeGorgeous.Services.Data.Categories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Data.Common.Repositories;
    using BeGorgeous.Data.Models;
    using BeGorgeous.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoryRepository)
        {
            this.categoriesRepository = categoryRepository;
        }


        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            IQueryable<Category> query = this.categoriesRepository.All();

            return await query.To<T>().ToListAsync();
        }

        public async Task AddAsync(string name, string description, string imageUrl)
        {
                await this.categoriesRepository.AddAsync(new Category
                {
                    Name = name,
                    Description = description,
                    ImageUrl = imageUrl,
                });

                await this.categoriesRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await this.categoriesRepository.AllAsNoTracking()
                                                          .Where(x => x.Id == id)
                                                          .FirstOrDefaultAsync();

            this.categoriesRepository.Delete(category);

            await this.categoriesRepository.SaveChangesAsync();
        }
    }
}
