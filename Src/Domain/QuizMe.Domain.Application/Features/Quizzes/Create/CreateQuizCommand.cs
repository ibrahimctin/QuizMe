
namespace QuizMe.Domain.Application.Features.Quizzes.Create
{
    public class CreateQuizCommand:IRequest<ValidatedResult<string>>
    {
        public CreateQuizRequest CreateQuizRequest { get; set; }
    }
}
