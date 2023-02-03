namespace QuizMe.Domain.Application.Features.Questions.Queries.GetQuestionDetail
{
    public class GetQuestionDetailRequest : IRequest<ValidatedResult<QuestionDetailResponse>>
    {
        public string Id { get; set; }
    }
}
