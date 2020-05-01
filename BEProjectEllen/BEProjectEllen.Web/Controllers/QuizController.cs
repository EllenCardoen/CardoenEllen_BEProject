using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BEProjectEllen.Core;
using BEProjectEllen.Core.Repositories;
using BEProjectEllen.Core.Services;
using BEProjectEllen.Core.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace BEProjectEllen.Web.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {
        private readonly IQuizRepo _quizRepo;
        private readonly IChoiceRepo _choiceRepo;
        private readonly IQuizService _quizService;
        private readonly IUserQuizRepo _userQuizRepo;
        private readonly IDifficultyRepo _difficultyRepo;

        public QuizController(IQuizRepo quizRepo, IChoiceRepo choiceRepo, IQuizService quizService, IUserQuizRepo userQuizRepo,IDifficultyRepo difficultyRepo)
        {
            _quizRepo = quizRepo;
            _choiceRepo = choiceRepo;
            _quizService = quizService;
            _userQuizRepo = userQuizRepo;
            _difficultyRepo = difficultyRepo;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var quizzes = await _quizRepo.GetAllAsync();
                var quizVMs = new List<QuizVM>();
                foreach (var quiz in quizzes)
                {

                    var quizid = quiz.Id;
                    var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var foundUserQuiz = await _userQuizRepo.GetUserQuizByMaximumScore(quizid, userid);

                    var quizVM = new QuizVM()
                    {
                        Quiz = quiz
                    };
                    
                    if(foundUserQuiz != null)
                    {
                        quizVM.BestScore = foundUserQuiz.EndScore;
                        quizVM.BestScoreDate = foundUserQuiz.Timestamp;
                    }

                    quizVMs.Add(quizVM);
                }


                return View(quizVMs);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IActionResult> CreateQuiz()
        {
            var quiz = new Quiz();
            

            var difficulties = await _difficultyRepo.GetAllAsync();
            ViewBag.DifficultyId = new SelectList(difficulties,"Id","Level");
            return View(quiz);
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuiz(Quiz quiz)
        {
            try
            {
                _quizRepo.Create(quiz);
                await _quizRepo.SaveAsync();

                //return View(quiz);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View(quiz);
            }
        }

        public async Task<IActionResult> Play(int id)
        {
            try
            {
                var quizzes = await _quizRepo.GetAsync(id);

                return View(quizzes);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpPost]
        public async Task<IActionResult> Play(List<int> choices, int id)
        {
            try
            {
                var quizzes = await _quizRepo.GetAsync(id);

                // Creat new UserQuiz
                //  GET user ID
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (userId == null || quizzes == null)
                    return View(quizzes);

                // make user choice
                if (choices.Count != quizzes.Questions.Count)
                {
                    // not all questions are filled in 
                    ModelState.AddModelError("count", "Not alle choices where filled in. Please start again");
                    return View(quizzes);
                }

                // TODO: place in service aub
                UserQuiz userQuiz = await _quizService.SaveUserQuiz(choices, id, userId);

                return RedirectToAction(nameof(Results), new { id = userQuiz.Id });
            }
            catch (Exception)
            {
                var quizzes = await _quizRepo.GetAsync(id);
                return View(quizzes);
            }
        }

        public async Task<IActionResult> Results(int id)
        {
            // 1. get list of user quiz . include answers . theninclude choices
            var UserQuiz = await _userQuizRepo.GetAsync(id);

            // 2. return
            return View(UserQuiz);

            //dynamic mymodel = new ExpandoObject();
            //mymodel.Result = await _userQuizRepo.GetAsync(id);
            //mymodel.HighScore = await _userQuizRepo.GetHighScore(10, id);
            //return View(mymodel);
        }

        public async Task<IActionResult> HighScore(int id)
        {
            //var userQuiz = await _userQuizRepo.GetHighScore(10, id);

            //return View(userQuiz);

            return ViewComponent("HighScore", new { Quizid = id });
        }
    }
}