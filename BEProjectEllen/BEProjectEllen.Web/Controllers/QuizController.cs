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
using BEProjectEllen.Web.Models;
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
        private readonly ILogger<QuizController> _logger;

        public QuizController(IQuizRepo quizRepo, IChoiceRepo choiceRepo, IQuizService quizService, IUserQuizRepo userQuizRepo, IDifficultyRepo difficultyRepo, ILogger<QuizController> logger)
        {
            _quizRepo = quizRepo;
            _choiceRepo = choiceRepo;
            _quizService = quizService;
            _userQuizRepo = userQuizRepo;
            _difficultyRepo = difficultyRepo;
            _logger = logger;
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

                    if (foundUserQuiz != null)
                    {
                        quizVM.BestScore = foundUserQuiz.EndScore;
                        quizVM.BestScoreDate = foundUserQuiz.Timestamp;
                    }

                    quizVMs.Add(quizVM);
                }


                return View(quizVMs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View("Error", new ErrorViewModel() { RequestId = HttpContext.TraceIdentifier });
            }
        }

        public async Task<IActionResult> CreateQuiz()
        {
            var quiz = new Quiz();


            List<Difficulty> diffList = new List<Difficulty>();
            diffList.Insert(0, new Difficulty { Level = "--- Choose difficulty level ---" });
            diffList.AddRange(await _difficultyRepo.GetAllAsync());
            ViewBag.DifficultyId = new SelectList(diffList, "Id", "Level");

            //var difficulties = await _difficultyRepo.GetAllAsync();
            //ViewBag.DifficultyId = new SelectList(difficulties,"Id","Level");

            return View(quiz);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateQuiz([Bind("Title,DifficultyId,Questions")] Quiz quiz)
        {
            try
            {
                if (quiz.DifficultyId == 0)
                {
                    quiz.DifficultyId = 1;
                }
                _quizRepo.Create(quiz);
                await _quizRepo.SaveAsync();

                //return View(quiz);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View("Error", new ErrorViewModel() { RequestId = HttpContext.TraceIdentifier });
            }
        }

        public async Task<IActionResult> Play(int id)
        {
            try
            {
                var quizzes = await _quizRepo.GetAsync(id);

                return View(quizzes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View("Error", new ErrorViewModel() { RequestId = HttpContext.TraceIdentifier });
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

                UserQuiz userQuiz = await _quizService.SaveUserQuiz(choices, id, userId);
                _logger.LogInformation($"Quiz completed by {User.Identity.Name}");
                return RedirectToAction(nameof(Results), new { id = userQuiz.Id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View("Error", new ErrorViewModel() { RequestId = HttpContext.TraceIdentifier });
            }
        }

        public async Task<IActionResult> Results(int id)
        {
            try
            {
                // 1. get list of user quiz . include answers . theninclude choices
                var UserQuiz = await _userQuizRepo.GetAsync(id);

                // 2. return
                return View(UserQuiz);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View("Error", new ErrorViewModel() { RequestId = HttpContext.TraceIdentifier });
                
            }
        }

        public async Task<IActionResult> HighScore(int id)
        {
            try
            {
                return ViewComponent("HighScore", new { Quizid = id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View("Error", new ErrorViewModel() { RequestId = HttpContext.TraceIdentifier });
            }


        }

        
    }
}