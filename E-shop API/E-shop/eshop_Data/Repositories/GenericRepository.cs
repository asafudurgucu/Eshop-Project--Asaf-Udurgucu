using eshop_Data.Abstract;
using eshop_Data.Contcrete.Context;
using eshop_Entity.Contcrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly EshopDbContext _context;  // _context'in türünü belirttik
        private readonly DbSet<T> _dbSet;

        // EshopContext ve DbSet<T> enjekte ediliyor
        public GenericRepository(EshopDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();  // _dbSet, context'ten türetiliyor
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync();
        }

        public async Task<int> CountAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.CountAsync(predicate);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<bool> ExistsAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<T> FindAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            int? take = null,
            params Func<IQueryable<T>, IQueryable<T>>[] includes)
        {
            IQueryable<T> query = _dbSet;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includes != null)
            {
                query = includes.Aggregate(
                    query,
                    (current, include) => include(current));
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (take.HasValue)
            {
                query = query.Skip(0).Take(take.Value);
            }

            return await query.ToListAsync();
        }

        public Task<T> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params Func<IQueryable<T>, IQueryable<T>>[] includes)
        {
            IQueryable<T> query = _dbSet;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => include(current));
            }
            return query.FirstOrDefaultAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
