using System;
using System.Collections.Generic;

namespace DomainDrivenDesign.Application.Interfaces
{
    public interface IAppServiceBase<TEntity>: IDisposable where TEntity: class
    {
        TEntity Add(TEntity entity);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity entity);
        void Delete(Guid id);
        IEnumerable<TEntity> Search(Func<TEntity, bool> predicate);
    }
}
