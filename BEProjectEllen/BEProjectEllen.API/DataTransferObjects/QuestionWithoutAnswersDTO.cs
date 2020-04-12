using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEProjectEllen.API.DataTransferObjects
{
    public class QuestionWithoutAnswersDTO : QuestionDTO
    {
        // lookup - one to many
        //deze DTO wordt enkel gebruikt om de gebruiker de juiste antwoorden niet te laten zien!!
        public virtual ICollection<ChoiceWithoutAnswersDTO> Choices { get; set; }
    }
}
