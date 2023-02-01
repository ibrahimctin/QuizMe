namespace QuizMe.Domain.Entities.DbModels.IdentityEntities
{
    public class AppUser:IdentityUser
    {
      

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public ICollection<QuizResult> QuestionResults { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Quiz> Quizzes { get; set; }
        public ICollection<Choice> Choices { get; set; }

    }
}
