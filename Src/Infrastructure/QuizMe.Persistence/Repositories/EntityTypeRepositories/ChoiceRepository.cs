

namespace QuizMe.Persistence.Repositories.EntityTypeRepositories
{
    public class ChoiceRepository : RepositoryBase<Choice>, IChoiceRepository
    {
        public ChoiceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
