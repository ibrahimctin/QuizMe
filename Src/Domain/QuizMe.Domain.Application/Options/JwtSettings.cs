namespace QuizMe.Domain.Application.Options
{
    public class JwtSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public IEnumerable<string> Audience { get; set; }
        public double DurationInMinutes { get; set; }
    }
}
