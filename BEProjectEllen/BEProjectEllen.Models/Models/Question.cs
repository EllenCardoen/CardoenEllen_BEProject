using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BEProjectEllen.Core
{
    public class Question 
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public int QuizId { get; set; }

        [Required]
        [Range(0, 300)]
        public int ScoreValue { get; set; }

        // lookup - one to many
        public virtual ICollection<Choice> Choices { get; set; }

        // lookup - navigation property
        public Quiz Quiz { get; set; }

        public Question()
        {
            this.Choices = new Collection<Choice>();
        }
    }
}
