

namespace QuizMe.Domain.Entities.DbModels
{
    public class Choice:BaseEntity<string>
    {
        public string? Text { get; set; }
        public bool CorrectAnswer { get; set; }
        public string QuestionId { get; set; }
        public Question? Question { get; set; }
    }
}
