namespace QuizMe.Domain.Application.Features.Questions.Commands.Delete
{
    public class DeleteQuestionCommandHandler : IRequestHandler<DeleteQuestionCommand, ValidatedResult<bool>>
    {

        
        private readonly IUnitOfWork _uOw;

        public DeleteQuestionCommandHandler( IUnitOfWork uOw)
        {
      
            _uOw = uOw;
        }

        public async Task<ValidatedResult<bool>> Handle(DeleteQuestionCommand request, CancellationToken cancellationToken)
        {

            var questionFromDb = await GetQuestion(request.Id);

            var deletedQuestion = await _uOw.questionRepository.DeleteAsync(ğ => ğ.Id == request.Id);
            

            if (deletedQuestion is false)
            {
                return ValidatedResult<bool>.Failed(404, "Couldn't find this Question");
            }
            var quiz = await GetQuiz(questionFromDb.QuizId);
            quiz.NumberOfQuestions--;
            _uOw.QuizRepository.Update(quiz);
            await _uOw.CommitAsync();
            return deletedQuestion is not true ? ValidatedResult<bool>.Failed() : ValidatedResult<bool>.Passed(true);
        }

        #region Private Queries

        private async Task<Quiz> GetQuiz(string id) => await _uOw.QuizRepository.GetAsync(ğ=>ğ.Id==id);
        private async Task<Question> GetQuestion(string id) => await _uOw.questionRepository.GetAsync(ğ => ğ.Id == id);
             
        #endregion

    }
}
