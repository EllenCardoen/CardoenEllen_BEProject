using BEProjectEllen.Core.Data;
using BEProjectEllen.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BEProjectEllen.Core.ViewComponents
{

    public class HighScoreViewComponent : ViewComponent
    {
        private readonly IUserQuizRepo _userQuizRepo;

        public HighScoreViewComponent(IUserQuizRepo userQuizRepo)
        {
            _userQuizRepo = userQuizRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync(int Quizid)
        {
            var items = await _userQuizRepo.GetHighScore(10, Quizid);
            return View(items);
        }


        //public async Task<IEnumerable<UserQuiz>> GetHighScore(int nmbr, int quizId)
        //{
        //    return await _userQuizRepo.UserQuizzes
        //        .Include(c => c.User)
        //        .Where(c => c.QuizId == quizId)
        //        .OrderByDescending(c => c.EndScore)
        //        .Take(nmbr)
        //        .ToListAsync();
        //}

        //public async Task<IEnumerable<UserQuiz>> GetCountHighScore(int count, int quizId)
        //{
        //    return await _context.UserQuizzes
        //        .Include(c => c.User)
        //        .Where(c => c.QuizId == quizId)
        //        .OrderByDescending(c => c.EndScore)
        //        .Take(count)
        //        .ToListAsync();
        //}

    }
}
