using System;
using System.Collections.Generic;

namespace DomainDrivenDesign.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        TEntity Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> Search(Func<TEntity, bool> predicate);
    }
}
