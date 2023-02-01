
namespace QuizMe.Domain.Application.Features.Quizzes.Create
{
    public class CreateQuizCommandHandler : IRequestHandler<CreateQuizCommand, ValidatedResult<string>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uOw;

        public CreateQuizCommandHandler(IMapper mapper,  IUnitOfWork uOw)
        {
            _mapper = mapper;
            _uOw = uOw;
        }

        public async Task<ValidatedResult<string>> Handle(CreateQuizCommand request, CancellationToken cancellationToken)
        {
            var quizPayload = _mapper.Map<Quiz>(request.CreateQuizRequest);

            if (quizPayload is not null)
            {
                await _uOw.QuizRepository.CreateAsync(quizPayload);
                await _uOw.CommitAsync();

                return ValidatedResult<string>.Passed(quizPayload.Id);
            }
            return ValidatedResult<string>.Failed(400);

        }
    }
}
