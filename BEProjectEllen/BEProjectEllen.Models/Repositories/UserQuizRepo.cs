using BEProjectEllen.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public class UserQuizRepo : GenericRepo<UserQuiz>, IUserQuizRepo
    {
        private readonly QuizDBContext _context;

        public UserQuizRepo(QuizDBContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<UserQuiz> GetAsync(int id)
        {
            return await _context.UserQuizzes
                .Include(c => c.UserChoices)
                .ThenInclude(c => c.Choice)
                .ThenInclude(c => c.Question)
                .Include(c => c.Quiz)
                .SingleOrDefaultAsync(c => c.Id == id)
                ;
        }

    }
}
