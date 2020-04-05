using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data.Infrastructure.Repository.Operation
{
    public interface IDeletableRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        void Delete(TEntity item);
    }
}
