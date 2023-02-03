using QuizMe.Domain.Application.Features.Questions.Queries.GetQuestionDetail;

namespace QuizMe.Domain.Application.Features.Quizzes.Queries
{
    public class GetQuizDetailRequestHandler : IRequestHandler<GetQuizDetailRequest, ValidatedResult<QuizDetailResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uOw;

        public GetQuizDetailRequestHandler(IMapper mapper, IUnitOfWork uOw)
        {
            _mapper = mapper;
            _uOw = uOw;
        }

        public async Task<ValidatedResult<QuizDetailResponse>> Handle(GetQuizDetailRequest request, CancellationToken cancellationToken)
        {
           
                var quizFromDb = await GetQuiz(request.Id);
                if (quizFromDb is null)
                {
                    return ValidatedResult<QuizDetailResponse>.Failed(404, "Couldn't find this Question");
                }
                var quizPayload = _mapper.Map<QuizDetailResponse>(quizFromDb);
                return ValidatedResult<QuizDetailResponse>.Passed(quizPayload);
            


           
        }
        #region Private Queries

        private async Task<Quiz> GetQuiz(string id) => await _uOw.QuizRepository.GetAsync(ğ => ğ.Id == id);

        #endregion
    }
}
