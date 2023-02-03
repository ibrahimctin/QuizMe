namespace QuizMe.Domain.Application.Features.Choices.Commands.Update
{
    public class UpdateChoiceCommandHandler : IRequestHandler<UpdateChoiceCommand, ValidatedResult<string>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uOw;

        public UpdateChoiceCommandHandler(IMapper mapper, IUnitOfWork uOw)
        {
            _mapper = mapper;
            _uOw = uOw;
        }

        public async Task<ValidatedResult<string>> Handle(UpdateChoiceCommand request, CancellationToken cancellationToken)
        {
            var choiceFromDb = await GetChoice(request.Id);

            if (choiceFromDb is null)
            {
                return ValidatedResult<string>.Failed(404, "Couldn't find this choice options");
            }

            var choicePayload = _mapper.Map(request.UpdateChoiceRequest, choiceFromDb);

            _uOw.ChoiceRepository.Update(choicePayload);

            await _uOw.CommitAsync();

            return choicePayload.Id is not null ? ValidatedResult<string>.Passed(choicePayload.Id) : ValidatedResult<string>.Failed(404);
        }

        #region Private Queries
        private async Task<Choice> GetChoice(string id) => await _uOw.ChoiceRepository.GetAsync(ğ => ğ.Id == id);
        #endregion

    }
}
