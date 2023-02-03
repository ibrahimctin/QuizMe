namespace QuizMe.Domain.Application.DTOs.Choices.RequestDtos
{
    public class UpdateChoiceRequest
    {
        public string Id { get; set; }
        public string? Text { get; set; }
        public bool CorrectAnswer { get; set; }
        public string QuestionId { get; set; }
    }
}
