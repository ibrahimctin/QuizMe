using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using QuizMe.Domain.Application.Helpers;
using QuizMe.Domain.Entities.DbModels.IdentityEntities;
using QuizMe.Infrastructure.Helpers;
using QuizMe.Persistence.Context;

namespace QuizMe.Infrastructure.Registrations
{
    public static class IdentityServicesRegistration
    {
        public static IServiceCollection ConfigureIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {



            services.TryAddScoped<IGenerateJwtToken, GenerateJwtToken>();
           



            return services;
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
            }).AddRoleManager<RoleManager<IdentityRole>>()
             .AddEntityFrameworkStores<AppDbContext>()
          .AddDefaultTokenProviders();
        }
    }
}
