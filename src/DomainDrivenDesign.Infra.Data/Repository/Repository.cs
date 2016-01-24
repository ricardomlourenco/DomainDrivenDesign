using System;
using System.Collections.Generic;
using System.Data.Entity;
using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.Domain.Interfaces.Repository;
using DomainDrivenDesign.Infra.Data.Context;
using System.Linq;

namespace DomainDrivenDesign.Infra.Data.Repository
{
    public class Repository<TEntity>:  IRepository<TEntity> where TEntity : class
    {
        private DefaultORMContext _dbContext;
        private DbSet<TEntity> _dbSet;

        public Repository(DefaultORMContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            var result = _dbSet.Add(entity);
            SaveChanges();
            return result;
        }

        public TEntity GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Always return top 10. We should never return more thant 10 items unless strict necessary.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList().Take(10);        
        }

        public TEntity Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> Search(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
           return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
