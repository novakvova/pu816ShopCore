using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Entities;

namespace Web.Shop.Repo.Interafaces
{
    public interface IBaseRepository<TEntity, TId> where TEntity : class, IBaseEntity<TId>
    {
        IQueryable<TEntity> GetAll(bool notDeleted = true);
        Task<TId> Add(TEntity entity);
        List<TEntity> GetPageList(int page);
    }
}
