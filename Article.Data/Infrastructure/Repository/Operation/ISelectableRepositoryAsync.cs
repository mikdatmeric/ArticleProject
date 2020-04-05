using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Article.Data.Infrastructure.Repository.Operation
{
    public interface ISelectableRepositoryAsync<TEntity> : IRepository<TEntity>
         where TEntity : IEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
