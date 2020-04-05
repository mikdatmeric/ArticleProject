using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data.Infrastructure.Repository.Operation
{
    interface ISelectableRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> GetAll();
    }
}
