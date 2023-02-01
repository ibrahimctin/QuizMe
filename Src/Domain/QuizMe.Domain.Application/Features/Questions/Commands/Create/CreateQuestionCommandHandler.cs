namespace QuizMe.Domain.Application.Features.Questions.Commands.Create
{
    public class CreateQuestionCommandHandler : IRequestHandler<CreateQuestionCommand, ValidatedResult<string>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uOw;

        public CreateQuestionCommandHandler(IMapper mapper, IUnitOfWork uOw)
        {
            _mapper = mapper;
            _uOw = uOw;
        }

        public async Task<ValidatedResult<string>> Handle(CreateQuestionCommand request, CancellationToken cancellationToken)
        {
            var quizFromDb = await GetQuizAsync(request.CreateQuestionRequest.QuizId);
            if (quizFromDb is null)
            {
                return ValidatedResult<string>.Failed(404, "Couldn't find this quiz");
            }

            quizFromDb.NumberOfQuestions++;
            _uOw.QuizRepository.Update(quizFromDb);
            var questionPaylaod = _mapper.Map<Question>(request.CreateQuestionRequest);

            await _uOw.questionRepository.CreateAsync(questionPaylaod);
            await _uOw.CommitAsync();

            return questionPaylaod.Id is not null ? ValidatedResult<string>.Passed(questionPaylaod.Id) : ValidatedResult<string>.Failed(404);



        }

        #region private Queries
        private async Task<Quiz> GetQuizAsync(string quizId) => await _uOw.QuizRepository.GetAsync(ğ => ğ.Id == quizId);
        #endregion
    }
}
