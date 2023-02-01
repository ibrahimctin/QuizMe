

namespace QuizMe.Domain.Application.Features.Identity.Authentication.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, AuthResponse>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IGenerateJwtToken _jwtToken;
        

        public LoginCommandHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IGenerateJwtToken jwtToken)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtToken = jwtToken;
            
        }

        public async Task<AuthResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                throw new Exception($"User with {request.Email} not found.");
            }

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, false, false);

            if (!result.Succeeded)
            {
                throw new Exception($"Credentials for '{request.Email} aren't valid'.");
            }

            var jwtSecurityToken = await _jwtToken.GenerateToken(user);

            AuthResponse response = new AuthResponse
            {
                Id = user.Id,
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                Email = user.Email,
                UserName = user.UserName
            };

            return response;


        }
    }
}
