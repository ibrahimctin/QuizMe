using QuizMe.Domain.Entities.DbModels.IdentityEntities;
using System.IdentityModel.Tokens.Jwt;

namespace QuizMe.Domain.Application.Helpers
{
    public interface IGenerateJwtToken
    {
        Task<JwtSecurityToken> GenerateToken(AppUser user);
    }
}
