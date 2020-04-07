using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Models
{
    public class UserQuiz
    {
        //Tussentabel om de gekozen quiz te spelen
        public int Id { get; set; }
        public  int QuizId { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        //deze endscore wordt enkel op het einde van de quiz gevuld, waardoor we kunnen weten of de quiz is afgelopen of niet.
        public int EndScore { get; set; }
    }
}
