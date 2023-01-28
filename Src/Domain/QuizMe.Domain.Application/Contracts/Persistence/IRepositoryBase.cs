using System.Linq.Expressions;

namespace QuizMe.Domain.Application.Contracts.Persistence
{
    public interface IRepositoryBase<T> where T : class
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
