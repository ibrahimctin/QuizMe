using QuizMe.Domain.Application.Contracts.Persistence.Repositories;
using QuizMe.Domain.Entities.DbModels;
using QuizMe.Persistence.Context;

namespace QuizMe.Persistence.Repositories.EntityTypeRepositories
{
    public class ChoiceRepository : RepositoryBase<Choice>, IChoiceRepository
    {
        public ChoiceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
