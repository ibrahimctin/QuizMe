using QuizMe.Domain.Entities.Common;
using System.Linq.Expressions;

namespace QuizMe.Domain.Application.Contracts.Persistence.Repositories
{
    public interface IRepositoryBase<T> where T : BaseEntity<string>, new()
    {
        ValueTask<T> CreateAsync(T entity);
        T Update(T entity);
        ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression);
        ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression,
            string[] includes = null,
            bool isTracking = true);

    }
}
