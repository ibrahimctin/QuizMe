// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizMe.Persistence.Context;

#nullable disable

namespace QuizMe.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230128173400_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.Choice", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("CorrectAnswer")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                            ConcurrencyStamp = "2919c775-efca-4d04-a196-8570b3e2ab19",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                            ConcurrencyStamp = "5bd70566-80fa-48b1-a457-01cd7ce4022c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "3DF53752-2022-47E8-898E-0CEA6206A47E",
                            ConcurrencyStamp = "4c77096b-4b20-4969-9cfa-8663133bbd4d",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "584d0749-7894-4e2c-beb0-d70e8880cf84",
                            Email = "superAdmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "İbrahim",
                            LastName = "Çetin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGhw2zTCpaPdbaX7/OKW8zI2+jvotrGYeFyyFVbB29vFBKzegxAWJUcBfoTzOAFGww==",
                            PhoneNumber = "+90535999999",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "4a7efd63-c24d-47a4-8612-3d0d77c09576",
                            TwoFactorEnabled = false,
                            UserName = "superAdmin@gmail.com"
                        },
                        new
                        {
                            Id = "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "49825f33-1e20-4ddd-ab50-7889964c2de9",
                            Email = "Admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Yusuf",
                            LastName = "Çetin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENggvyXo8HiiWcF2LmlYI5rZ275SNH08+R1MV+Sp7bxyCW6f7Ro9WCD2ILTg2QiUgw==",
                            PhoneNumber = "+90535999999",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "84db181d-d874-45d9-8639-0daf15b0c709",
                            TwoFactorEnabled = false,
                            UserName = "Admin@gmail.com"
                        });
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                            RoleId = "ee72cc84-0cfb-4ba5-8a51-55c3c85d23f2"
                        },
                        new
                        {
                            UserId = "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                            RoleId = "e4e7b010-deb1-4bc9-bb59-572332e969d7"
                        });
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUserToken", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.Question", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("QuizId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.Quiz", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfQuestions")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.QuizResult", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CorrectAnswers")
                        .HasColumnType("int");

                    b.Property<string>("QuizId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.HasIndex("UserId");

                    b.ToTable("QuizResults");
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.Choice", b =>
                {
                    b.HasOne("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUser", null)
                        .WithMany("Choices")
                        .HasForeignKey("AppUserId");

                    b.HasOne("QuizMe.Domain.Entities.DbModels.Question", "Question")
                        .WithMany("Choices")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppRoleClaim", b =>
                {
                    b.HasOne("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUserClaim", b =>
                {
                    b.HasOne("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUserLogin", b =>
                {
                    b.HasOne("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUserRole", b =>
                {
                    b.HasOne("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUserToken", b =>
                {
                    b.HasOne("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.Question", b =>
                {
                    b.HasOne("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUser", null)
                        .WithMany("Questions")
                        .HasForeignKey("AppUserId");

                    b.HasOne("QuizMe.Domain.Entities.DbModels.Quiz", null)
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.Quiz", b =>
                {
                    b.HasOne("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUser", null)
                        .WithMany("Quizzes")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.QuizResult", b =>
                {
                    b.HasOne("QuizMe.Domain.Entities.DbModels.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUser", "User")
                        .WithMany("QuestionResults")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.IdentityEntities.AppUser", b =>
                {
                    b.Navigation("Choices");

                    b.Navigation("QuestionResults");

                    b.Navigation("Questions");

                    b.Navigation("Quizzes");
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.Question", b =>
                {
                    b.Navigation("Choices");
                });

            modelBuilder.Entity("QuizMe.Domain.Entities.DbModels.Quiz", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
