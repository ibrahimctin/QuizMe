

namespace QuizMe.Domain.Application.Features.Choices.Queries
{
    public class GetChoiceDetailRequest:IRequest<ValidatedResult<ChoiceDetailResponse>>
    {
        public string Id { get; set; }
    }
}
