using QuizMe.Domain.Application.Contracts.Persistence.Repositories;

namespace QuizMe.Domain.Application.Contracts.Persistence.Uow
{
    public interface IUnitOfWork:IDisposable
    {
        IQuizRepository QuizRepository { get; }
        IChoiceRepository ChoiceRepository { get; }
        IQuizResultRepository quizResultRepository { get; }
        IQuestionRepository questionRepository { get; }
        Task CommitAsync();

    }
}
