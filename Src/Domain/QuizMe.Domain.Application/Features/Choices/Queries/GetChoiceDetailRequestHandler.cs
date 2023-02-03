
namespace QuizMe.Domain.Application.Features.Choices.Queries
{
    public class GetChoiceDetailRequestHandler : IRequestHandler<GetChoiceDetailRequest, ValidatedResult<ChoiceDetailResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uOw;

        public GetChoiceDetailRequestHandler(IMapper mapper, IUnitOfWork uOw)
        {
            _mapper = mapper;
            _uOw = uOw;
        }

        public async Task<ValidatedResult<ChoiceDetailResponse>> Handle(GetChoiceDetailRequest request, CancellationToken cancellationToken)
        {
            var choiceFromDb = await GetChoice(request.Id);
            if (choiceFromDb is null)
            {
                return ValidatedResult<ChoiceDetailResponse>.Failed(404, "Couldn't find this Question");
            }
            var choicePayload = _mapper.Map<ChoiceDetailResponse>(choiceFromDb);
            return ValidatedResult<ChoiceDetailResponse>.Passed(choicePayload);
        }


        #region Private Queries

        private async Task<Choice> GetChoice(string id) => await _uOw.ChoiceRepository.GetAsync(ğ => ğ.Id == id);

        #endregion
    }
}
