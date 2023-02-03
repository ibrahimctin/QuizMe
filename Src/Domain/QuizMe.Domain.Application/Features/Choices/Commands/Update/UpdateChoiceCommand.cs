namespace QuizMe.Domain.Application.Features.Choices.Commands.Update
{
    public class UpdateChoiceCommand:IRequest<ValidatedResult<string>>
    {
        public string? Id { get; set; }
        public UpdateChoiceRequest UpdateChoiceRequest { get; set; }
    }
}
