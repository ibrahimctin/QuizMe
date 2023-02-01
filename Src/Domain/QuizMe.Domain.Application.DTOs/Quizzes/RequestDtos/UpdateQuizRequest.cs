



namespace QuizMe.Domain.Application.DTOs.Quizzes.RequestDtos
{
    public class UpdateQuizRequest
    {
        [JsonIgnore]
        public string? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
