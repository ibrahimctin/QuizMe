using QuizMe.Domain.Application.Contracts.Persistence.Repositories;
using QuizMe.Domain.Entities.DbModels;
using QuizMe.Persistence.Context;

namespace QuizMe.Persistence.Repositories.EntityTypeRepositories
{
    public class QuizRepository : RepositoryBase<Quiz>, IQuizRepository
    {
        public QuizRepository(AppDbContext context) : base(context)
        {
        }
    }
}
