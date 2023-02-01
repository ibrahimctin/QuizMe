namespace QuizMe.Domain.Application.Features.Questions.Commands.Create
{
    public class CreateQuestionCommand : IRequest<ValidatedResult<string>>
    {
        public CreateQuestionRequest CreateQuestionRequest { get; set; }
    }
}
