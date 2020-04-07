﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int QuizId { get; set; }
        public int ScoreValue { get; set; }
    }
}
