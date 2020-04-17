using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BEProjectEllen.Core
{
    public class UserQuiz
    {
        //Tussentabel om de gekozen quiz te spelen
        public int Id { get; set; }
        public  int QuizId { get; set; }
        public string UserId { get; set; }
        public DateTime Timestamp { get; set; }

        //deze endscore wordt enkel op het einde van de quiz gevuld, waardoor we kunnen weten of de quiz is afgelopen of niet.
        public int EndScore { get; set; }

        
        // lookup - navigation property
        public Quiz Quiz { get; set; }

        public IdentityUser User { get; set; }
        // lookup - one to many
        public virtual ICollection<UserChoice> UserChoices { get; set; }

        public UserQuiz()
        {
            UserChoices = new Collection<UserChoice>();
        }
    }
}
