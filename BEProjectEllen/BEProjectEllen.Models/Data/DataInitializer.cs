using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Data
{
    public static class DataInitializer
    {
        // extention method
        public static void Seed(this ModelBuilder modelBuilder)
        {   
            
            // any guid
            const string ELLENID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string DOCENTID = "a18be9c0-aa65-4af8-bd17-15bd9344e575";
            // any guid, but nothing is against to use the same one
            const string ROLE_ID = ELLENID;

            IdentityUser ellen = new IdentityUser
            {
                Id = ELLENID,
                UserName = "Ellen",
                Email = "ellen@student.com",
                NormalizedEmail = "ellen@student.com".ToUpper(),
                NormalizedUserName = "EllenCardoen".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumberConfirmed = false
            };

            IdentityUser docent = new IdentityUser
            {
                Id=DOCENTID,
                UserName = "Docent@MCT",
                Email = "docent@MCT.com",
                NormalizedEmail = "docent@MCT.com".ToUpper(),
                NormalizedUserName = "DocentMCT".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumberConfirmed = false
            };

            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            ellen.PasswordHash = ph.HashPassword(ellen, "ellen");
            docent.PasswordHash = ph.HashPassword(docent, "Docent@1"); 


            modelBuilder.Entity<IdentityUser>().HasData(ellen);
            modelBuilder.Entity<IdentityUser>().HasData(docent);


            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN",Id = ROLE_ID },
                new IdentityRole { Name = "User", NormalizedName = "USER" }
            );

            modelBuilder.Entity<Difficulty>().HasData(
                new Difficulty { Id = 1, Level = "Easy" },
                new Difficulty { Id = 2, Level = "Normal" },
                new Difficulty { Id = 3, Level = "Hard" },
                new Difficulty { Id = 4, Level = "Challenging" }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = ROLE_ID, UserId = ELLENID },
                new IdentityUserRole<string> { RoleId = ROLE_ID, UserId = DOCENTID });            
        }
    }
}
