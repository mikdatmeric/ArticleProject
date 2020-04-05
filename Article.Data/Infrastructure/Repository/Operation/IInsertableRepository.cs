using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data.Infrastructure.Repository.Operation
{
    public interface IInsertableRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        TEntity Insert(TEntity item);
    }
}
