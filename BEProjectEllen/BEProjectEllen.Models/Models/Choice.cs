using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BEProjectEllen.Core
{
    public class Choice
    {
        public int Id { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public bool IsCorrect { get; set; }
        
        public string Explanation { get; set; }

        // lookup - navigation property
        public Question Question { get; set; }


        // lookup - one to many
        public virtual ICollection<UserChoice> UserChoices { get; set; }

        public Choice()
        {
            UserChoices = new Collection<UserChoice>();
        }


    }
}
