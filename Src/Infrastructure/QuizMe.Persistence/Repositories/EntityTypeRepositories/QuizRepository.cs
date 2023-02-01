
namespace QuizMe.Persistence.Repositories.EntityTypeRepositories
{
    public class QuizRepository : RepositoryBase<Quiz>, IQuizRepository
    {
        public QuizRepository(AppDbContext context) : base(context)
        {
        }
    }
}
