namespace QuizMe.Domain.Application.Features.Quizzes.Update
{
    public class UpdateQuizCommand:IRequest<ValidatedResult<string>>
    {
        public string Id { get; set; }
        public UpdateQuizRequest UpdateQuizRequest { get; set; }
    }
}
