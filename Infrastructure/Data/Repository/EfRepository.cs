using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repository
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext _dbContext;

        public EfRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected DbSet<TEntity> _dbSet
        {
            get
            {
                return _dbContext.Set<TEntity>();
            }
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Remove(entity);
        }

        public virtual TEntity Find(long id)
        {
            return _dbSet.Find(id);
        }

        public TEntity Find(Func<TEntity, bool> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public virtual IEnumerable<TEntity> FindAll()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<TEntity> FindAll(Func<TEntity, bool> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public void Update(TEntity entity)
        {
            _dbContext.Update(entity);
        }
    }
}
