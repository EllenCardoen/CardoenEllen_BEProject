using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Core.Data
{
    public class QuizDBContext : IdentityDbContext
    {
        public QuizDBContext(DbContextOptions<QuizDBContext> options) : base(options)
        {
                
        }

        //Dbsets (kolommen in database)
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }

        //veel op veel relaties
        public DbSet<UserChoice> UserChoices { get; set; }
        public DbSet<UserQuiz> UserQuizzes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserChoice>().HasOne(uc => uc.UserQuiz).WithMany(p => p.UserChoices).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserChoice>(entity =>
            {
                entity.HasKey(t => new { t.UserQuizId, t.ChoiceId });
            });

            modelBuilder.Seed();

        }
    }
 }
