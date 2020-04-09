using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BEProjectEllen.Core
{
    public class Quiz
    {
        public int Id { get; set; }
        public  string Title { get; set; }

        public string DifficultyId { get; set; }

        // lookup - one to many
        public virtual ICollection<Question> Questions { get; set; }

        // lookup - navigation property
        public Difficulty Difficulty { get; set; }

        public Quiz()
        {
            this.Questions = new Collection<Question>();
        }

    }
}
