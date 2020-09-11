using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.database.repository.abstraction.@interface
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();

        ValueTask<T> GetOneAsync(Guid id);

        void DeleteAsync(T entity);

        void UpdateAsync(T entity);

        ValueTask<EntityEntry<T>> InsertAsync(T entity);

        Task<int> CommitAsync();
    }
}