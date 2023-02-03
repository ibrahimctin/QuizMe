namespace QuizMe.Domain.Application.Features.Questions.Queries.GetQuestionDetail
{
    public class GetQuestionDetailRequesHandler : IRequestHandler<GetQuestionDetailRequest, ValidatedResult<QuestionDetailResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uOw;

        public GetQuestionDetailRequesHandler(IMapper mapper, IUnitOfWork uOw)
        {
            _mapper = mapper;
            _uOw = uOw;
        }

        public async Task<ValidatedResult<QuestionDetailResponse>> Handle(GetQuestionDetailRequest request, CancellationToken cancellationToken)
        {
            var questionFromDb = await GetQuestion(request.Id);
            if (questionFromDb is null)
            {
                return ValidatedResult<QuestionDetailResponse>.Failed(404, "Couldn't find this Question");
            }
            var questionPayload = _mapper.Map<QuestionDetailResponse>(questionFromDb);
            return ValidatedResult<QuestionDetailResponse>.Passed(questionPayload);
        }


        #region Private Queries

        private async Task<Question> GetQuestion(string id) => await _uOw.questionRepository.GetAsync(ğ => ğ.Id == id, new string[] { "Choices" });

        #endregion
    }
}
