namespace QuizMe.Domain.Application.Features.Choices.Commands.Create
{
    public class CreateChoiceCommandHandler : IRequestHandler<CreateChoiceCommand, ValidatedResult<string>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uOw;

        public CreateChoiceCommandHandler(IMapper mapper, IUnitOfWork uOw)
        {
            _mapper = mapper;
            _uOw = uOw;
        }

        public async Task<ValidatedResult<string>> Handle(CreateChoiceCommand request, CancellationToken cancellationToken)
        {
            var questionFromDb = await GetQuestion(request.CreateChoiceRequest.QuestionId);
            if (questionFromDb is null)
            {
                return ValidatedResult<string>.Failed(404, "Couldn't find this Question");
            }
            var questionPayload = _mapper.Map<Choice>(request.CreateChoiceRequest);
            await _uOw.ChoiceRepository.CreateAsync(questionPayload);
            await _uOw.CommitAsync();
            return questionPayload.Id is not null ? ValidatedResult<string>.Passed(questionPayload.Id) : ValidatedResult<string>.Failed(404);

        }


        #region Private Queries
        private async Task<Question> GetQuestion(string id) => await _uOw.questionRepository.GetAsync(ğ => ğ.Id == id);
        #endregion

    }
}
