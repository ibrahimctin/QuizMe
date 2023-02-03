namespace QuizMe.Domain.Application.Features.Choices.Commands.Delete
{
    public class DeleteChoiceCommand:IRequest<ValidatedResult<bool>>
    {
        public string Id { get; set; }
    }
}
