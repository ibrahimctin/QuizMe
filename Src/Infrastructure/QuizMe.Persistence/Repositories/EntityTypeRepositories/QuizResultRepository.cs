using QuizMe.Domain.Application.Contracts.Persistence.Repositories;
using QuizMe.Domain.Entities.DbModels;
using QuizMe.Persistence.Context;

namespace QuizMe.Persistence.Repositories.EntityTypeRepositories
{
    public class QuizResultRepository : RepositoryBase<QuizResult>, IQuizResultRepository
    {
        public QuizResultRepository(AppDbContext context) : base(context)
        {
        }
    }
}
