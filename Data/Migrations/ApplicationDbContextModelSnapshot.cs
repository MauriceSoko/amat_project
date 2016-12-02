using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using amat_project.Data;

namespace amat_project.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("amat_project.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("amat_project.Models.Enseignant", b =>
                {
                    b.Property<string>("EnseignantId");

                    b.Property<string>("ApplicationUserID");

                    b.Property<string>("SessionId");

                    b.HasKey("EnseignantId");

                    b.HasIndex("ApplicationUserID");

                    b.HasIndex("SessionId");

                    b.ToTable("Enseignant");
                });

            modelBuilder.Entity("amat_project.Models.Etudiant", b =>
                {
                    b.Property<string>("EtudiantId");

                    b.Property<string>("ApplicationUserID");

                    b.Property<string>("SessionId");

                    b.HasKey("EtudiantId");

                    b.HasIndex("ApplicationUserID");

                    b.HasIndex("SessionId");

                    b.ToTable("Etudiant");
                });

            modelBuilder.Entity("amat_project.Models.Evaluation", b =>
                {
                    b.Property<string>("EvaluationId");

                    b.Property<string>("EnseignantId");

                    b.Property<string>("EtudiantId");

                    b.Property<string>("ModuleId");

                    b.Property<int>("Note");

                    b.Property<string>("SessionId");

                    b.HasKey("EvaluationId");

                    b.HasIndex("EnseignantId");

                    b.HasIndex("EtudiantId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("SessionId");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("amat_project.Models.Formation", b =>
                {
                    b.Property<string>("FormationId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("FormationId");

                    b.ToTable("Formation");
                });

            modelBuilder.Entity("amat_project.Models.FormationModule", b =>
                {
                    b.Property<string>("ModuleId");

                    b.Property<string>("FormationId");

                    b.HasKey("ModuleId", "FormationId");

                    b.HasIndex("FormationId");

                    b.HasIndex("ModuleId");

                    b.ToTable("FormationModule");
                });

            modelBuilder.Entity("amat_project.Models.Module", b =>
                {
                    b.Property<string>("ModuleId");

                    b.Property<string>("Description");

                    b.Property<string>("EnseignantId");

                    b.Property<string>("Name");

                    b.HasKey("ModuleId");

                    b.HasIndex("EnseignantId");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("amat_project.Models.ModuleEnseignant", b =>
                {
                    b.Property<string>("EnseignantId");

                    b.Property<string>("ModuleId");

                    b.HasKey("EnseignantId", "ModuleId");

                    b.HasIndex("EnseignantId");

                    b.HasIndex("ModuleId");

                    b.ToTable("ModuleEnseignant");
                });

            modelBuilder.Entity("amat_project.Models.Session", b =>
                {
                    b.Property<string>("SessionId");

                    b.Property<DateTime>("DebutSession");

                    b.Property<DateTime>("FinSession");

                    b.Property<string>("FormationId");

                    b.HasKey("SessionId");

                    b.HasIndex("FormationId");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("amat_project.Models.Enseignant", b =>
                {
                    b.HasOne("amat_project.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserID");

                    b.HasOne("amat_project.Models.Session")
                        .WithMany("Enseignants")
                        .HasForeignKey("SessionId");
                });

            modelBuilder.Entity("amat_project.Models.Etudiant", b =>
                {
                    b.HasOne("amat_project.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserID");

                    b.HasOne("amat_project.Models.Session")
                        .WithMany("Etudiants")
                        .HasForeignKey("SessionId");
                });

            modelBuilder.Entity("amat_project.Models.Evaluation", b =>
                {
                    b.HasOne("amat_project.Models.Enseignant", "Enseignant")
                        .WithMany()
                        .HasForeignKey("EnseignantId");

                    b.HasOne("amat_project.Models.Etudiant", "Etudiant")
                        .WithMany("Evaluations")
                        .HasForeignKey("EtudiantId");

                    b.HasOne("amat_project.Models.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId");

                    b.HasOne("amat_project.Models.Session", "Session")
                        .WithMany()
                        .HasForeignKey("SessionId");
                });

            modelBuilder.Entity("amat_project.Models.FormationModule", b =>
                {
                    b.HasOne("amat_project.Models.Formation", "Formation")
                        .WithMany("FormationModules")
                        .HasForeignKey("FormationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("amat_project.Models.Module", "Module")
                        .WithMany("FormationModules")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("amat_project.Models.Module", b =>
                {
                    b.HasOne("amat_project.Models.Enseignant")
                        .WithMany("Modules")
                        .HasForeignKey("EnseignantId");
                });

            modelBuilder.Entity("amat_project.Models.ModuleEnseignant", b =>
                {
                    b.HasOne("amat_project.Models.Enseignant", "Enseignant")
                        .WithMany("ModuleEnseignants")
                        .HasForeignKey("EnseignantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("amat_project.Models.Module", "Module")
                        .WithMany("ModuleEnseignants")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("amat_project.Models.Session", b =>
                {
                    b.HasOne("amat_project.Models.Formation", "Formation")
                        .WithMany("Sessions")
                        .HasForeignKey("FormationId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("amat_project.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("amat_project.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("amat_project.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
