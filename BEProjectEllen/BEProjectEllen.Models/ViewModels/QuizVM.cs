using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Core.ViewModels
{
    public class QuizVM
    {
        public Quiz Quiz { get; set; }
        public int? BestScore { get; set; }
        public DateTime? BestScoreDate { get; set; }
    }
}
