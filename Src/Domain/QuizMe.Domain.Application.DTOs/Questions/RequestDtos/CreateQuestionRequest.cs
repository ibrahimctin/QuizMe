namespace QuizMe.Domain.Application.DTOs.Questions.RequestDtos
{
    public class CreateQuestionRequest
    {
        public string QuizId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
       
    }
}
