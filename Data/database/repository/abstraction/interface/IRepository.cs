using System;
using System.Collections.Generic;

namespace Data.database.repository.abstraction.@interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetOne(Guid id);

        void Delete(T entity);

        void Update(T entity);

        void Insert(T entity);

        void Commit();
    }
}