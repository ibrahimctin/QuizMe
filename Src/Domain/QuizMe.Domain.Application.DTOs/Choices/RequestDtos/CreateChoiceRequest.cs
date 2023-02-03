namespace QuizMe.Domain.Application.DTOs.Choices.RequestDtos
{
    public class CreateChoiceRequest
    {
        public string? Text { get; set; }
        public bool CorrectAnswer { get; set; }
        public string QuestionId { get; set; }
    }
}
