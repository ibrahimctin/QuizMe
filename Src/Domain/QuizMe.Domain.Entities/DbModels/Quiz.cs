

namespace QuizMe.Domain.Entities.DbModels
{
    public class Quiz : BaseEntity<string>
    {
        public int NumberOfQuestions { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        
    }
}
