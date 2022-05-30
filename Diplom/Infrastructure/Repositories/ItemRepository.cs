using JWT.Domain.Models;
using JWT.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JWT.Infrastructure.Repositories
{
    public class ItemRepository
    {
        private readonly UserContext _context;
        private char _splitter = ',';
        public ItemRepository(UserContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetQueryable<TEntity>(Expression<Func<TEntity, bool>> filter = null,
            bool includeDeleted = false,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null,
            int? skip = null,
            int? take = null)
            where TEntity : class, IBaseEntry
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!includeDeleted)
            {
                query = query.Where(x => !x.IsDelete);
            }

            foreach (var includeProperty in includeProperties.Split(_splitter, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return query.AsNoTracking();
        }

        public async Task<IList<TEntity>> GetAll<TEntity>(Expression<Func<TEntity, bool>> filter = null,
            bool includeDeleted = false,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null,
            int? skip = null,
            int? take = null)
            where TEntity : class, IBaseEntry
        {
            return await GetQueryable<TEntity>(filter, includeDeleted, orderBy, includeProperties, skip, take).ToListAsync();
        }

        public async Task<TEntity> GetFirst<TEntity>(Expression<Func<TEntity, bool>> filter = null,
        bool includeDeleted = false,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = null,
        int? skip = null,
        int? take = null)
        where TEntity : class, IBaseEntry
        {
            return await GetQueryable<TEntity>(filter, includeDeleted, orderBy, includeProperties, skip, take).FirstAsync();
        }

        public async Task<bool> CheckIfExist<TEntity>(Expression<Func<TEntity, bool>> filter = null,
        bool includeDeleted = false,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = null,
        int? skip = null,
        int? take = null)
        where TEntity : class, IBaseEntry
        {
            return await GetQueryable<TEntity>(filter, includeDeleted, orderBy, includeProperties, skip, take).AnyAsync();
        }

        public async Task<int> GetCount<TEntity>(Expression<Func<TEntity, bool>> filter = null,
        bool includeDeleted = false,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = null,
        int? skip = null,
        int? take = null)
        where TEntity : class, IBaseEntry
        {
            return await GetQueryable<TEntity>(filter, includeDeleted, orderBy, includeProperties, skip, take).CountAsync();
        }

        public async Task<TSelect> GetFirstSelectable<TEntity, TSelect>(Expression<Func<TEntity, TSelect>> select,
        Expression<Func<TEntity, bool>> filter = null,
        bool includeDeleted = false,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = null,
        int? skip = null,
        int? take = null)
        where TEntity : class, IBaseEntry
        {
            return await GetQueryable<TEntity>(filter, includeDeleted, orderBy, includeProperties, skip, take).Select(select).FirstOrDefaultAsync();
        }

        public async Task Edit<TEntity>(TEntity model)
            where TEntity : class, IBaseEntry
        {
            if (model.Id == Guid.Empty)
                _context.Set<TEntity>().Add(model);
            else
            {
                _context.Entry(model).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }

        public async Task Delete<TEntity>(Guid id)
            where TEntity : class, IBaseEntry
        {
            var model = await GetFirst<TEntity>(filter: x => x.Id == id);
            model.IsDelete = true;
            await Edit(model);
        }
    }
}