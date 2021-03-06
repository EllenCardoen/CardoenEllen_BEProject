﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BEProjectEllen.Core
{
    public class Quiz
    {
        public int Id { get; set; }

        [Required]
        public  string Title { get; set; }

        [Required]
        public int DifficultyId { get; set; }

        // lookup - one to many
        public virtual ICollection<Question> Questions { get; set; }

        public virtual ICollection<UserQuiz> UserQuizzes { get; set; }
        // lookup - navigation property
        public Difficulty Difficulty { get; set; }

        public Quiz()
        {
            this.Questions = new Collection<Question>();
            this.UserQuizzes = new Collection<UserQuiz>();
        }

    }
}
