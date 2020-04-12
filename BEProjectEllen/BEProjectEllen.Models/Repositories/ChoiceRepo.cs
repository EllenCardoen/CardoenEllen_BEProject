using BEProjectEllen.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Core.Repositories
{
    public class ChoiceRepo : GenericRepo<Choice>, IChoiceRepo
    {
        private readonly QuizDBContext _context;

        public ChoiceRepo(QuizDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
