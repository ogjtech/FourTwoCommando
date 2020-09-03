using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.database.repository.abstraction.@interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.database.repository.abstraction
{
    public abstract class AsyncRepository<T> : IAsyncRepository<T> where T : class
    {
        private FourTwoCommandoContext _context;
        private DbSet<T> _dbSet;

        public AsyncRepository(FourTwoCommandoContext ctx)
        {
            _context = ctx;
            _dbSet = _context.Set<T>();
        }
        
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async ValueTask<T> GetOneAsync(Guid id)
        {
            return await _dbSet.FindAsync(id.ToString());
        }

        public void DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
        }

        public async ValueTask<EntityEntry<T>> InsertAsync(T entity)
        {
            return await _dbSet.AddAsync(entity);
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}