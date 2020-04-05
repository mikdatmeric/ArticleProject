using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data.Infrastructure.Repository
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
    }
}
