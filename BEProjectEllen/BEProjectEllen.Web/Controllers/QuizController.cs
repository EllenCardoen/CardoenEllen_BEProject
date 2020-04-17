using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEProjectEllen.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BEProjectEllen.Web.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuizRepo _repo;

        public QuizController(IQuizRepo repo)
        {
            _repo = repo;
        }
        public  async Task<IActionResult> Index()
        {
            try
            {
                var quizzes = await _repo.GetAllAsync();

                return View(quizzes);
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        public async Task<IActionResult> Play(int id)
        {
            try
            {
                var quizzes = await _repo.GetAsync(id);

                return View(quizzes);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}