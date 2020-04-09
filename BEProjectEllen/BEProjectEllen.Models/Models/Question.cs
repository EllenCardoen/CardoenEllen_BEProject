using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BEProjectEllen.Core
{
    public class Question 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int QuizId { get; set; }
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
