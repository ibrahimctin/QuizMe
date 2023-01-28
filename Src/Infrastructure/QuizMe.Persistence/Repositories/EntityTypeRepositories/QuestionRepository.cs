using QuizMe.Domain.Application.Contracts.Persistence.Repositories;
using QuizMe.Domain.Entities.DbModels;
using QuizMe.Persistence.Context;

namespace QuizMe.Persistence.Repositories.EntityTypeRepositories
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        public QuestionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
