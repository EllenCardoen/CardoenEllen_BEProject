using BEProjectEllen.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthenticationService(UserManager<IdentityUser> userManager, IConfiguration configuration, ILogger<AuthenticationService> logger, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _configuration = configuration;
            _logger = logger;
            _signInManager = signInManager;
        }
        public async Task<bool> Login(Login login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.UserName, login.Password, false, lockoutOnFailure: false);
            return result.Succeeded;
        }

        public async Task<BearerToken> GenerateJWT(string name)
        {
            var user = await _userManager.FindByNameAsync(name);
            var userClaims = await _userManager.GetClaimsAsync(user);


            if (userClaims.Count == 0)
            {
                var roles = await _userManager.GetRolesAsync(user);

                foreach (var role in roles)
                {
                    var claim = new Claim(ClaimTypes.Role, role);
                    await _userManager.AddClaimAsync(user, claim);
                    userClaims.Add(claim);
                }
            }

            userClaims.Add(new Claim(JwtRegisteredClaimNames.Sub, name)); //subscriber
            userClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

            // Sigin credentials met de symmetric key & encryptie methode
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256); //key en protocol

            // aanmaken van het token
            var token = new JwtSecurityToken(
             issuer: _configuration["Tokens:Issuer"],  //onze website
             audience: _configuration["Tokens:Audience"],//gebruikers
             claims: userClaims,
             expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Tokens: Expires"])),
             signingCredentials: creds //controleert token v
             );

            // user info returnen (vervaldatum als additionele info)
            return new BearerToken
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token), //token generator
                Expiration = token.ValidTo
            };
        }
    }
}
