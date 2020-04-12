using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEProjectEllen.API.DataTransferObjects
{
    public class ChoiceDTO : ChoiceWithoutAnswersDTO
    {
        
        public bool IsCorrect { get; set; }
        public string Explanation { get; set; }

       
    }
}
