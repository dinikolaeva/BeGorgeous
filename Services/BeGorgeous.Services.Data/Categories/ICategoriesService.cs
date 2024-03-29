﻿namespace BeGorgeous.Services.Data.Categories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICategoriesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task AddAsync(string name, string description, string imageUrl);

        Task DeleteAsync(int id);
    }
}
