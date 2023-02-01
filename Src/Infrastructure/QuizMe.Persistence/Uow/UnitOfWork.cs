

namespace QuizMe.Persistence.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IQuestionRepository _questionRepository;
        private IQuizRepository _quizRepository;
        private IQuizResultRepository _quizResultRepository;
        private IChoiceRepository _choiceRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IQuizRepository QuizRepository => _quizRepository ?? new QuizRepository(_context);
        public IChoiceRepository ChoiceRepository => _choiceRepository ?? new ChoiceRepository(_context);
        public IQuizResultRepository quizResultRepository => _quizResultRepository ?? new QuizResultRepository(_context);
        public IQuestionRepository questionRepository => _questionRepository ?? new QuestionRepository(_context);


        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
