
namespace QuizMe.Domain.Application.Helpers
{
    public interface IGenerateJwtToken
    {
        Task<JwtSecurityToken> GenerateToken(AppUser user);
    }
}
