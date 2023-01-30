using System.ComponentModel.DataAnnotations;

namespace QuizMe.Domain.Application.DTOs.Users.Authentication.RequestDtos
{
    public class RegisterRequest
    {
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords must match.")]
        public string ConfirmPassword { get; set; }
        public string Roles { get; set; }
    }
}
