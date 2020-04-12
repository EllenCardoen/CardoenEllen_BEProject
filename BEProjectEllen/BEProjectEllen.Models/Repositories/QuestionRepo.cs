using BEProjectEllen.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Core.Repositories
{
    public class QuestionRepo : GenericRepo<Question>, IQuestionRepo
    {
        private readonly QuizDBContext _context;

        public QuestionRepo(QuizDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
