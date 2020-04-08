using BEProjectEllen.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Core.Repositories
{
    public class UserChoiceRepo
    {
        //Add userchoice
        private readonly QuizDBContext _context;

        public UserChoiceRepo(QuizDBContext context)
        {
            this._context = context;
        }


    }
}
