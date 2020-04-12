using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEProjectEllen.API.DataTransferObjects
{
    public class SaveQuizDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int DifficultyId { get; set; }

        // lookup - one to many
        public virtual ICollection<QuestionWithAnswersDTO> Questions { get; set; }
    }
}
