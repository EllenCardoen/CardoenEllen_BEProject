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
            //TODO: roles toevoegen aan gebuikers, ellen en johan krijgen Admin role!!      
                        
            IdentityUser ellen = new IdentityUser
            {
                UserName = "Ellen",
                Email = "ellen@student.com",
                NormalizedEmail = "ellen@student.com".ToUpper(),
                NormalizedUserName = "EllenCardoen".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumberConfirmed = false
            };

            IdentityUser johan = new IdentityUser
            {
                UserName = "Johan",
                Email = "johan@docent.com",
                NormalizedEmail = "johan@docent.com".ToUpper(),
                NormalizedUserName = "JohanMCT".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumberConfirmed = false
            };


            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            ellen.PasswordHash = ph.HashPassword(ellen, "ellen");
            johan.PasswordHash = ph.HashPassword(johan, "docent");

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "User", NormalizedName = "USER" }
            );

            modelBuilder.Entity<Difficulty>().HasData(
                new Difficulty { Id = 1, Level = "Easy" },
                new Difficulty { Id = 2, Level = "Normal" },
                new Difficulty { Id = 3, Level = "Hard" },
                new Difficulty { Id = 4, Level = "Challenging" }
            );

            modelBuilder.Entity<IdentityUser>().HasData(ellen);
            modelBuilder.Entity<IdentityUser>().HasData(johan);
        }
    }
}
