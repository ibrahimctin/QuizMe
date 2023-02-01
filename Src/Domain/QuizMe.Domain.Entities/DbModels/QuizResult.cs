


namespace QuizMe.Domain.Entities.DbModels
{
    public class QuizResult : BaseEntity<string>
    {
        public int CorrectAnswers { get; set; }
        public string QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
