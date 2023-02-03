namespace QuizMe.Domain.Application.Features.Choices.Commands.Create
{
    public class CreateChoiceCommand:IRequest<ValidatedResult<string>>
    {
        public CreateChoiceRequest CreateChoiceRequest { get; set; }
    }
}
