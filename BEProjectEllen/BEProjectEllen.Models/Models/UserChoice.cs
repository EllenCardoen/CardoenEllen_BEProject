using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Core
{
    public class UserChoice
    {
        //tussentabel die wordt gebruikt om de gemaakte keuze van de user op te slaan

        public int UserQuizId { get; set; }
        public int ChoiceId { get; set; }

        // lookup - navigation property
        public UserQuiz UserQuiz { get; set; }
        public Choice Choice { get; set; }
    }
}
