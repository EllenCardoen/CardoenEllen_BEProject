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
            return _context.Quizzes
                .Include(q => q.Questions).ThenInclude(q => q.Choices)
                .Include(q => q.Difficulty)
                .SingleOrDefaultAsync(q => q.Id == Id);
        }

        public override async Task<IEnumerable<Quiz>> GetAllAsync()
        {
            return await _context.Quizzes
               .Include(q => q.Difficulty)
               .ToListAsync();
        }

        public void AddUserQuiz(UserQuiz userQuiz)
        {
            _context.UserQuizzes.Add(userQuiz);
        }
        


    }
}
