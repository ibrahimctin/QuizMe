namespace QuizMe.Domain.Application.Features.Questions.Commands.Update
{
    public class UpdateQuestionCommand:IRequest<ValidatedResult<string>>
    {
        public string Id { get; set; }
        public UpdateQuestionRequest UpdateQuestionRequest { get; set; }
    }
}
