using Microsoft.EntityFrameworkCore;
using QuizMe.Domain.Application.Contracts.Persistence;
using QuizMe.Domain.Entities.Common;
using QuizMe.Persistence.Context;
using System.Linq.Expressions;

namespace QuizMe.Persistence.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity<string>
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async ValueTask<T> CreateAsync(T entity) =>
            (await _context.AddAsync(entity)).Entity;


        public async ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await GetAsync(expression);

            if (entity == null)
                return false;

            _dbSet.Remove(entity);

            return true;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression, string[] includes = null, bool isTracking = true)
        {
            IQueryable<T> query = expression is null ? _dbSet : _dbSet.Where(expression);

            if (includes != null)
                foreach (var include in includes)
                    if (!string.IsNullOrEmpty(include))
                        query = query.Include(include);

            if (!isTracking)
                query = query.AsNoTracking();

            return query;
        }

        public async ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null) =>
         await GetAll(expression, includes, false).FirstOrDefaultAsync();

        public  T Update(T entity)=>  _dbSet.Update(entity).Entity;
        
    }
}
