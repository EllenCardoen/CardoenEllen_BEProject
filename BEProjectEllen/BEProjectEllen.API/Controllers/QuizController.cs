using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEProjectEllen.Core;
using BEProjectEllen.Core.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BEProjectEllen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizRepo _quizrepo;
        private readonly ILogger<QuizController> _logger;

        public QuizController(IQuizRepo quizrepo, ILogger<QuizController> logger)
        {
            this._quizrepo = quizrepo;
            _logger = logger;
        }



        // GET: api/Quiz
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var quizzes = await _quizrepo.GetQuizzesAsync();
                return Ok(quizzes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        //TODO: get met id uitwerken!
        // GET: api/Quiz/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }



        // POST: api/Quiz
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Quiz quiz)
        {
            try
            {
                await _quizrepo.AddQuizAsync(quiz);
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _quizrepo.DeleteQuiz(id);
                return NoContent();

            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
    }
}
