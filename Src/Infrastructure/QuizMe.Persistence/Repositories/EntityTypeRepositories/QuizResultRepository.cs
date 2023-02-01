
namespace QuizMe.Persistence.Repositories.EntityTypeRepositories
{
    public class QuizResultRepository : RepositoryBase<QuizResult>, IQuizResultRepository
    {
        public QuizResultRepository(AppDbContext context) : base(context)
        {
        }
    }
}
