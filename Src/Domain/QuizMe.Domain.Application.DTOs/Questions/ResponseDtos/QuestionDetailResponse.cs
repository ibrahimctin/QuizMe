namespace QuizMe.Domain.Application.DTOs.Questions.ResponseDtos
{
    public class QuestionDetailResponse
    {
        [JsonIgnore]
        public string? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
    }
}
