namespace QuizMe.Domain.Application.Features.Quizzes.Queries
{
    public class GetQuizDetailRequest:IRequest<ValidatedResult<QuizDetailResponse>>
    {
        public string Id { get; set; }
    }
}
