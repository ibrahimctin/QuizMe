namespace QuizMe.Domain.Application.Features.Questions.Commands.Update
{
    public class UpdateQuestionCommandHandler : IRequestHandler<UpdateQuestionCommand, ValidatedResult<string>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uOw;

        public UpdateQuestionCommandHandler(IMapper mapper, IUnitOfWork uOw)
        {
            _mapper = mapper;
            _uOw = uOw;
        }

        public async Task<ValidatedResult<string>> Handle(UpdateQuestionCommand request, CancellationToken cancellationToken)
        {
            var questionFromDb = await GetQuestion(request.Id);

            if (questionFromDb is null)
            {
                return ValidatedResult<string>.Failed(404, "Couldn't find this Question");
            }

            var questionPayload = _mapper.Map(request.UpdateQuestionRequest,questionFromDb);

            _uOw.questionRepository.Update(questionPayload);

            await _uOw.CommitAsync();

            return questionFromDb.Id is not null ? ValidatedResult<string>.Passed(questionFromDb.Id) : ValidatedResult<string>.Failed(404);
        }


        #region Private Queries
        private async Task<Question> GetQuestion(string id) => await _uOw.questionRepository.GetAsync(ğ=>ğ.Id== id);
        #endregion
    }
}
