﻿

using QuizMe.Domain.Application.DTOs.Quizzes.ResponseDtos;

namespace QuizMe.Domain.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            
            CreateMap<AppUser,RegisterRequest>().ReverseMap();  
            CreateMap<AppUser,AppUserDetailResponse>().ReverseMap();

            CreateMap<Quiz, CreateQuizRequest>().ReverseMap();
            CreateMap<Quiz, UpdateQuizRequest>().ReverseMap();
            CreateMap<Quiz, QuizDetailResponse>().ReverseMap();
            
        }
    }
}
