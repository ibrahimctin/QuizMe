namespace QuizMe.Domain.Application.Features.Choices.Commands.Delete
{
    public class DeleteChoiceCommandHandler : IRequestHandler<DeleteChoiceCommand, ValidatedResult<bool>>
    {
        private readonly IUnitOfWork _uOw;

        public DeleteChoiceCommandHandler(IUnitOfWork uOw)
        {
            _uOw = uOw;
        }

        public async Task<ValidatedResult<bool>> Handle(DeleteChoiceCommand request, CancellationToken cancellationToken)
        {
            var deletedChoice = await _uOw.ChoiceRepository.DeleteAsync(ğ => ğ.Id == request.Id);

            if (deletedChoice is false)
            {
                return ValidatedResult<bool>.Failed(404, "Couldn't find this quiz");
            }
            await _uOw.CommitAsync();


            return deletedChoice is not true ? ValidatedResult<bool>.Failed() : ValidatedResult<bool>.Passed(true);

        }
    }
}
