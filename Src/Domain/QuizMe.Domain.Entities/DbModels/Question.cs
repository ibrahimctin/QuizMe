


namespace QuizMe.Domain.Entities.DbModels
{
    public class Question:BaseEntity<string>
    {
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        public string Text { get; set; }
        public string QuizId { get; set; }
        public  ICollection<Choice> Choices { get; set; }
    }
}
