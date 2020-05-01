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
               .Include(uc => uc.UserChoices)
               .ThenInclude(uc => uc.Choice)
               .ThenInclude(c => c.Question)
               .SingleOrDefaultAsync(c => c.Id == id)
               ;


        }

        public async Task<UserQuiz> GetUserQuizByMaximumScore(int quizId, string userId)
        {
            try
            {
                var result = _context.UserQuizzes.AsQueryable();

                result = result.Where(uq => uq.QuizId == quizId && uq.UserId == userId);
                result = result.OrderByDescending(c => c.EndScore);

                return await result.FirstOrDefaultAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<UserQuiz>> GetHighScore(int nmbr, int quizId)
        {
            return await _context.UserQuizzes
                .Include(c => c.User)
                .Where(c => c.QuizId == quizId)
                .OrderByDescending(c => c.EndScore)
                .Take(nmbr)
                .ToListAsync();
        }

        public async Task<IEnumerable<UserQuiz>> GetCountHighScore(int count, int quizId)
        {
            return await _context.UserQuizzes
                .Include(c => c.User)
                .Where(c => c.QuizId == quizId)
                .OrderByDescending(c => c.EndScore)                
                .Take(count)
                .ToListAsync();
        }
    }
}
