namespace QuizMe.Domain.Application.Features.Quizzes.Queries.GetQuizDetail
{
    public class GetQuizDetailRequest : IRequest<ValidatedResult<QuizDetailResponse>>
    {
        public string Id { get; set; }
    }
}
