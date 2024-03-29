﻿namespace BeGorgeous.Services.Data.Cities
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICitiesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task<IEnumerable<T>> GetAllSalonsByCityIdAsync<T>(int cityId);

        Task AddAsync(string name, int countryId);

        Task DeleteAsync(int id);

        Task<int> GetCitiesCountAsync();
    }
}
