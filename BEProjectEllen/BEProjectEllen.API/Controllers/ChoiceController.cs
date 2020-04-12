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
    public class ChoiceController : ControllerBase
    {
        private readonly IChoiceRepo _choiceRepo;
        private readonly ILogger<ChoiceController> _logger;
        private readonly IMapper _mapper;

        public ChoiceController(IChoiceRepo choiceRepo, ILogger<ChoiceController> logger, IMapper mapper)
        {
            _choiceRepo = choiceRepo;
            _logger = logger;
            _mapper = mapper;
        }


        // GET: api/Choice
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var choices = await _choiceRepo.GetAllAsync();

                var choicesDTO = _mapper.Map<IEnumerable<ChoiceDTO>>(choices);

                return Ok(choicesDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // GET: api/Choice/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var choice = await _choiceRepo.GetAsync(id);

                if (choice == null)
                    return NotFound();

                var choiceDTO = _mapper.Map<ChoiceDTO>(choice);

                return Ok(choiceDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // POST: api/Choice
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ChoiceWithoutAnswersDTO choice)
        {
            try
            {
                //1 map questionDTO naar question
                var mappedChoice = _mapper.Map<Choice>(choice);

                if (mappedChoice == null)
                    return NotFound();

                //  2. ADD TO REPO
                _choiceRepo.Create(mappedChoice);

                // 3 . savechanges async
                await _choiceRepo.SaveAsync();

                // 4. map to dto (niet save dto)


                // 5 . return created at action
                return Ok(mappedChoice);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // PUT: api/Choice/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ChoiceDTO choice)
        {
            try
            {
                var mappedChoice = _mapper.Map<Question>(choice);

                var foundChoice = _choiceRepo.GetAsync(id);

                if (foundChoice == null)
                    return NotFound();

                await _choiceRepo.SaveAsync();

                return Ok(foundChoice);
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
