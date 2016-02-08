using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DomainDrivenDesign.Domain.Interfaces.Repository;
using DomainDrivenDesign.Infra.Data.Context;

namespace DomainDrivenDesign.Infra.Data.Repository
{
    public class Repository<TEntity>:  IRepository<TEntity> where TEntity : class
    {
        protected DefaultORMContext _dbContext;
        protected DbSet<TEntity> _dbSet;

        public Repository(DefaultORMContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentException();
            }
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            var result = _dbSet.Add(entity);
            SaveChanges();
            return result;
        }

        public TEntity GetById(int id)
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

        public TEntity Update(TEntity entity)
        {
            var entry = _dbContext.Entry(entity);
            _dbSet.Attach(entity);
            SaveChanges();

            return entity;
        }

        public void Delete(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            SaveChanges();
        }

        public virtual IEnumerable<TEntity> Search(Func<TEntity, bool> predicate)
        {
            return _dbSet.Where(predicate);
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
