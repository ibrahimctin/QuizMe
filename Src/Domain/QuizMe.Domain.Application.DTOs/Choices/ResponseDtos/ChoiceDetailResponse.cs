

namespace QuizMe.Domain.Application.DTOs.Choices.ResponseDtos
{
    public class ChoiceDetailResponse
    {
        public string? Text { get; set; }
        public bool CorrectAnswer { get; set; }
        public string QuestionId { get; set; }
        public QuestionDetailResponse Question { get; set; }
    }
}
