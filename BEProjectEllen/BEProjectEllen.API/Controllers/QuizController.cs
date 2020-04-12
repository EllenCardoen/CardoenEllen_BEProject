using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BEProjectEllen.API.DataTransferObjects;
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
        private readonly IMapper _mapper;

        public QuizController(IQuizRepo quizrepo, ILogger<QuizController> logger, IMapper mapper)
        {
            this._quizrepo = quizrepo;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: api/Quiz
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var quizzes = await _quizrepo.GetAllAsync();

                var quizzesDTO = _mapper.Map<IEnumerable<QuizDTO>>(quizzes);

                return Ok(quizzesDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // GET: api/Quiz/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var quiz = await _quizrepo.GetAsync(id);

                if (quiz == null)
                    return NotFound();

                var quizDTO = _mapper.Map<QuizDTO>(quiz);

                return Ok(quizDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }


        // POST: api/Quiz
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SaveQuizDTO quiz)
        {
            try
            {
                //1 map save quiz dto naar quiz
                var mappedQuiz = _mapper.Map<Quiz>(quiz);

                if (mappedQuiz == null)
                    return NotFound();

                //  2. ADD TO REPO

                _quizrepo.Create(mappedQuiz);

                // 3 . savechanges async
                await _quizrepo.SaveAsync();

                // 4. map to dto (niet save dto)
                var quizDto = _mapper.Map<QuizDTO>(mappedQuiz);

                // 5 . return created at action
                return Ok(quizDto);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // PUT: api/quiz/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] SaveQuizDTO saveQuizDto)
        {
            try
            {
                if( saveQuizDto.Id != id)
                {
                    return BadRequest();
                }

                var foundQuiz = await _quizrepo.GetAsync(id);

                if (foundQuiz == null)
                    return NotFound();

                _mapper.Map(saveQuizDto, foundQuiz);

                await _quizrepo.SaveAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }




        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var foundQuiz = await _quizrepo.GetAsync(id);

                if (foundQuiz == null)
                    return NotFound();


                _quizrepo.Delete(foundQuiz);

                await _quizrepo.SaveAsync();

                return NoContent();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }
    }
}
