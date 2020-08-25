using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Entities;
using Web.Shop.Repo.Interafaces;

namespace Web.Shop.Repo.Implement
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity : class, IBaseEntity<TId>
    {
        public DbContext Context { get; }
        public DbSet<TEntity> DbSet { get; }

        public BaseRepository(DbContext context)
        {
            this.Context = context;
            this.DbSet = this.Context.Set<TEntity>();
        }
        public virtual IQueryable<TEntity> GetAll(bool notDeleted = true)
        {
            var query = DbSet.AsQueryable();
            if (notDeleted)
                query = query.Where(x => x.DateDelete!=null);
            return DbSet.AsQueryable();
        }

        public virtual async Task<TId> Add(TEntity entity)
        {
            await this.DbSet.AddAsync(entity);
            this.Context.SaveChanges();
            return entity.Id;
        }

        public List<TEntity> GetPageList(int page)
        {
            int pageSize = 2;
            int pageNo = page - 1;
            var query = this.GetAll();
            var list = query.OrderBy(x=>x.Id)
                .Skip(pageNo * pageSize)
                .Take(pageSize)
                .ToList();
            return list;
        }
    }
}
