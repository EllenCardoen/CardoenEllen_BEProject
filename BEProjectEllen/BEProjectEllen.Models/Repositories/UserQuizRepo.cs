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

        //public  async Task<UserQuiz> GetAsync(int quizId, string userId)
        //{
        //    var test =  _context.UserQuizzes               
        //        .Where(c => c.QuizId == quizId &&  userId == c.UserId);

        //}

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

    }
}
