using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using System.Linq;
using System;
using amat_project.Data;

namespace amat_project.Models
{
    public static class IdentityExtension
    {
        public static void EnsureRolesCreated(this IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetService<ApplicationDbContext>();
            if (context.AllMigrationsApplied())
            {
                var roleManager = app.ApplicationServices.GetService<RoleManager<IdentityRole>>();
                foreach (var role in Roles.All)
                {
                    if (!roleManager.RoleExistsAsync(role.ToUpper()).Result)
                    {
                        roleManager.CreateAsync(new IdentityRole { Name = role });
                    }

                }
                

                // add an a user with admin role
            var adminUser = new ApplicationUser
            { 
                UserName = "admin@mail.com",
                 Email = "admin@mail.com",
                 EmailConfirmed = true,
                 PhoneNumberConfirmed = true,
                 SecurityStamp = Guid.NewGuid().ToString("D")

            };
                if(!context.Users.Any(u => u.UserName == adminUser.UserName))
                {
                    UserManager<ApplicationUser> umanager = app.ApplicationServices.GetService<UserManager<ApplicationUser>>();
                    var passwordAdmin = new PasswordHasher<ApplicationUser>();
                    var hashed = passwordAdmin.HashPassword(adminUser, "Password1_");
                    adminUser.PasswordHash = hashed;

                    var userStore = new UserStore<ApplicationUser>(context);
                    var result = userStore.CreateAsync(adminUser);
                    umanager.AddToRoleAsync(adminUser,Roles.Admin);
                }
            }
        }
    }
}