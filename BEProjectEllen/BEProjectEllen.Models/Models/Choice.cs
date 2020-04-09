using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BEProjectEllen.Core
{
    public class Choice
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
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
