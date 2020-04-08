using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Core.Data
{
    public class QuizDBContext : DbContext
    {
        public QuizDBContext(DbContextOptions<QuizDBContext> options) : base(options)
        {
                
        }

        //Dbsets (kolommen in database)
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizDifficulty> QuizDifficulties { get; set; }

        //veel op veel relaties
        public DbSet<UserChoice> UserChoices { get; set; }
        public DbSet<UserQuiz> UserQuizzes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                       
            modelBuilder.Entity<UserQuiz>(entity =>
            {
                entity.HasKey(t => new { t.Id, t.UserId });
            });

            modelBuilder.Entity<UserChoice>(entity =>
            {
                entity.HasKey(t => new { t.UserQuizId, t.ChoiceId });
            });



            //Identity kolom            
            //modelBuilder.Entity<Quiz>().Property(e => e.Id).UseIdentityColumn();



            //---Enkele fluent API mogelijkheden---

            //1. Tabelnamen,kolomnamen aanpassen 
            //modelBuilder.Entity<Teacher>().Property(t => t.Birthday).HasColumnName("DateOfBirth");

            //2.Constraints aan modelproperties toevoegen voor input validatie.Chainen van properties kan in de lambda functie: 
            //modelBuilder.Entity<Person>().Property(a=>a.Naam).IsRequired(); 
            //modelBuilder.Entity<Customer>(entity => { 
            //entity.Property(e => e.FirstName).HasMaxLength(20); 
            //entity.Property(e => e.LastName).IsRequired().HasMaxLength(40); 
            //}); 

            //3 Relaties van de entiteiten beïnvloeden 
            //---Composiet (of dubbele) key maken voor een tussentabel. 
            //modelBuilder.Entity<PersonsCategories>() .HasKey(p => new { p.PersonID, p.CategoryID }); 

            //---een property niet scaffolden voor de views (veiligheid): 
            //modelBuilder.Entity<Education>(entity => { entity.Property(e => e.Id).ValueGeneratedNever(); }); 

            //---een property die niet bestaat in de database: 
            //modelBuilder.Entity<Person>().Ignore(t=> t.ImageUrl); 

            //---een property met een andere naam in de database: 
            //modelBuilder.Entity<Teacher>().Property(t =>t.Birthday) .HasColumnName("DateOfBirth"); 

            //---een property als Primary Key aanduiden: 
            //modelBuilder.Entity<Education>().Property (e=>e.Id) .UseIdentityColumn();
        }

    }
}
