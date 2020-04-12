using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEProjectEllen.API.DataTransferObjects
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int QuizId { get; set; }
        public int ScoreValue { get; set; }

    }
}
