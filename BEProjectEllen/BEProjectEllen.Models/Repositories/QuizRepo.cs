using BEProjectEllen.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public class QuizRepo : IQuizRepo
    {
        private readonly QuizDBContext _context;
        public QuizRepo(QuizDBContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Quiz>> GetQuizzesAsync()
        {
            return await _context.Quizzes.ToListAsync();
        }

        public async Task<Quiz> AddQuizAsync(Quiz quiz)
        {
            try
            {
                var result = _context.Quizzes.AddAsync(quiz);
                await _context.SaveChangesAsync();
                return quiz;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return null;
            }
        }

        public async Task DeleteQuiz(int id)
        {
            try
            {
                Quiz quiz = await GetQuizWithIdAsync(id);
                if (quiz == null)
                {
                    return;
                }

                var result = _context.Quizzes.Remove(quiz);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public async Task<Quiz> GetQuizWithIdAsync(int id)
        {
            Quiz quiz = await _context.Quizzes.FindAsync(id);
            return quiz;
        }


    }
}
