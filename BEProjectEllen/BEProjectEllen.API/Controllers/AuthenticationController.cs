using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEProjectEllen.Core.Models;
using BEProjectEllen.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BEProjectEllen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly ILogger<AuthenticationController> _logger;

        public AuthenticationController(IAuthenticationService authenticationService, ILogger<AuthenticationController> logger)
        {
            _authenticationService = authenticationService;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            try
            {
                if (!await _authenticationService.Login(login))
                {
                    _logger.LogWarning($"Login failed for {login.UserName}");
                    return BadRequest("Credentials are not correct");

                }
                
                var token = await _authenticationService.GenerateJWT(login.UserName);
                _logger.LogInformation($"{login.UserName} succesfully logged in @{DateTime.Now}");
                return Ok(token);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message);
                return BadRequest();
            }
        
        }
    }
}