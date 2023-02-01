using System.Text.Json.Serialization;

namespace QuizMe.Domain.Application.Features.Questions.Commands.Delete
{
    public class DeleteQuestionCommand : IRequest<ValidatedResult<bool>>
    {
        public string Id { get; set; }
        [JsonIgnore]
        public string? quizId { get; set; }

    }
}
