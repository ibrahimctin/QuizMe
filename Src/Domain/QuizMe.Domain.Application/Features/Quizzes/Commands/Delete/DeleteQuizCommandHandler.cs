namespace QuizMe.Domain.Application.Features.Quizzes.Commands.Delete
{
    public class DeleteQuizCommandHandler : IRequestHandler<DeleteQuizCommand, ValidatedResult<bool>>
    {

        private readonly IUnitOfWork _uOw;

        public DeleteQuizCommandHandler(IUnitOfWork uOw)
        {
            _uOw = uOw;
        }

        public async Task<ValidatedResult<bool>> Handle(DeleteQuizCommand request, CancellationToken cancellationToken)
        {

            var deletedQuiz = await _uOw.QuizRepository.DeleteAsync(ğ => ğ.Id == request.Id);

            if (deletedQuiz is false)
            {
                return ValidatedResult<bool>.Failed(404, "Couldn't find this quiz");
            }
            await _uOw.CommitAsync();


            return deletedQuiz is not true ? ValidatedResult<bool>.Failed() : ValidatedResult<bool>.Passed(true);

        }


    }
}
