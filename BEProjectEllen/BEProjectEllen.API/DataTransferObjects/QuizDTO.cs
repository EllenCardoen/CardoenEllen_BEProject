using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEProjectEllen.API.DataTransferObjects
{
    public class QuizDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Difficulty { get; set; }

        // lookup - one to many
        public virtual ICollection<QuestionWithAnswersDTO> Questions { get; set; }
    }
}
