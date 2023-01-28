using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizMe.Domain.Entities.DbModels.IdentityEntities;

namespace QuizMe.Infrastructure.Configurations
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");


            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("B6EEEB2E-9361-44BF-B189-3ED9BB58E495").ToString(),
                RoleId = Guid.Parse("EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2").ToString()
            },
            new AppUserRole
            {
                RoleId = Guid.Parse("E4E7B010-DEB1-4BC9-BB59-572332E969D7").ToString(),
                UserId = Guid.Parse("B9C6085D-D150-43E0-B2E2-1B7D05477D1B").ToString()
            }
            );
        }
    }
}
