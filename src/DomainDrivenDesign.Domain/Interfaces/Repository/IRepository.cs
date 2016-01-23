using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DomainDrivenDesign.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        TEntity Add(TEntity entity);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity obj);
        void Remove(Guid id);
        IEnumerable<TEntity> Search(Func<TEntity, bool> predicate);
        int SaveChanges();
    }
}
