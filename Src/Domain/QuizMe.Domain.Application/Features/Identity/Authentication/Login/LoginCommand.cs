
namespace QuizMe.Domain.Application.Features.Identity.Authentication.Login
{
    public class LoginCommand:IRequest<AuthResponse>
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
