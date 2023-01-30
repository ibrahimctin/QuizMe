using MediatR;
using Microsoft.AspNetCore.Identity;
using QuizMe.Domain.Application.DTOs.Users.Authentication.RequestDtos;

namespace QuizMe.Domain.Application.Features.Identity.Authentication.Register
{
    public class RegisterCommand:IRequest<IdentityResult>
    {
        public RegisterRequest RegisterRequest { get; set; }
    }
}
