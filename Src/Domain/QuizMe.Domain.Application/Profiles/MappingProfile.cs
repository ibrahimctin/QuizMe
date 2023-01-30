using AutoMapper;
using QuizMe.Domain.Application.DTOs.Users.Authentication.RequestDtos;
using QuizMe.Domain.Application.DTOs.Users.ResponseDtos;
using QuizMe.Domain.Entities.DbModels.IdentityEntities;

namespace QuizMe.Domain.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            
            CreateMap<AppUser,RegisterRequest>().ReverseMap();  
            CreateMap<AppUser,AppUserDetailResponse>().ReverseMap();
            
        }
    }
}
