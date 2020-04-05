using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data.Infrastructure.Repository.Operation
{
    public interface IUpdatableRepository<TEntity> : IRepository<TEntity>
         where TEntity : IEntity
    {
        TEntity Update(TEntity item);
    }
}
