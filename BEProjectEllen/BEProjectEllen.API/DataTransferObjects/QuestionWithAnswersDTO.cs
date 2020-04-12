using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEProjectEllen.API.DataTransferObjects
{
    public class QuestionWithAnswersDTO : QuestionDTO
    {
        public virtual ICollection<ChoiceDTO> Choices { get; set; }
    }
}
