namespace QuizMe.Domain.Application.Features.Quizzes.Commands.Update
{
    public class UpdateQuizCommandHandler : IRequestHandler<UpdateQuizCommand, ValidatedResult<string>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uOw;

        public UpdateQuizCommandHandler(IMapper mapper, IUnitOfWork uOw)
        {
            _mapper = mapper;
            _uOw = uOw;
        }

        public async Task<ValidatedResult<string>> Handle(UpdateQuizCommand request, CancellationToken cancellationToken)
        {
            var quizFromDb = await GetQuiz(request.Id);

            if (quizFromDb is null)
            {
                return ValidatedResult<string>.Failed(404, "Couldn't find this quiz");
            }

            var quizPayload = _mapper.Map(request.UpdateQuizRequest, quizFromDb);

            _uOw.QuizRepository.Update(quizPayload);

            await _uOw.CommitAsync();

            return quizPayload.Id is not null ? ValidatedResult<string>.Passed(quizPayload.Id) : ValidatedResult<string>.Failed(404);
        }


        #region Private Queries

        private async Task<Quiz> GetQuiz(string id) => await _uOw.QuizRepository.GetAsync(ğ => ğ.Id == id);

        #endregion
    }
}
