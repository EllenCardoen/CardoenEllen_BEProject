using BEProjectEllen.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public class QuizRepo : GenericRepo<Quiz>, IQuizRepo
    {
        private readonly QuizDBContext _context;
        public QuizRepo(QuizDBContext context):base(context)
        {
            this._context = context;
        }

        public override Task<Quiz> GetAsync(int Id)
        {
            return _context.Quizzes.Include(q => q.Questions).ThenInclude(q => q.Choices).SingleOrDefaultAsync(q => q.Id == Id);
        }



    }
}
