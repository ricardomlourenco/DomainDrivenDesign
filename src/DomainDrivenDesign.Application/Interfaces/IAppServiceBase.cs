using System;
using System.Collections.Generic;

namespace DomainDrivenDesign.Application.Interfaces
{
    public interface IAppServiceBase<TEntity>: IDisposable where TEntity: class
    {
        TEntity Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> Search(Func<TEntity, bool> predicate);
    }
}
