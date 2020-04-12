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
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepo _questionRepo;
        private readonly ILogger<QuestionController> _logger;
        private readonly IMapper _mapper;

        public QuestionController(IQuestionRepo questionRepo, ILogger<QuestionController> logger, IMapper mapper)
        {
            _questionRepo = questionRepo;
            _logger = logger;
            _mapper = mapper;
        }


        // GET: api/Question
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var questions = await _questionRepo.GetAllAsync();

                var questionsDTO = _mapper.Map<IEnumerable<QuestionDTO>>(questions);

                return Ok(questionsDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // GET: api/Question/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var question = await _questionRepo.GetAsync(id);

                if (question == null)
                    return NotFound();

                var questionDTO = _mapper.Map<QuestionDTO>(question);

                return Ok(questionDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // POST: api/Question
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] QuestionWithAnswersDTO question)
        {
            try
            {
                //1 map questionDTO naar question
                var mappedQuestion = _mapper.Map<Question>(question);

                if (mappedQuestion == null)
                    return NotFound();

                //  2. ADD TO REPO
                _questionRepo.Create(mappedQuestion);

                // 3 . savechanges async
                await _questionRepo.SaveAsync();

                // 4. map to dto (niet save dto)


                // 5 . return created at action
                return Ok(mappedQuestion);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // PUT: api/Question/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] QuestionDTO question)
        {
            try
            {
                var mappedQuestion = _mapper.Map<Question>(question);

                var foundQuestion = _questionRepo.GetAsync(id);

                if (foundQuestion == null)
                    return NotFound();

                await _questionRepo.SaveAsync();

                return Ok(foundQuestion);
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
