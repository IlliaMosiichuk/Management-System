using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Find(long id);

        TEntity Find(Func<TEntity, bool> predicate);

        IEnumerable<TEntity> FindAll();

        IEnumerable<TEntity> FindAll(Func<TEntity, bool> predicate);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
