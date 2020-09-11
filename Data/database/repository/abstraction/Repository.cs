using System;
using System.Collections.Generic;
using System.Linq;
using Data.database.repository.abstraction.@interface;
using Microsoft.EntityFrameworkCore;

namespace Data.database.repository.abstraction
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private FourTwoCommandoContext _context;
        private DbSet<T> _dbSet;

        public Repository(FourTwoCommandoContext ctx)
        {
            _context = ctx;
            _dbSet = ctx.Set<T>();
        }
        
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetOne(Guid id)
        {
            return _dbSet.Find(id.ToString());
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}