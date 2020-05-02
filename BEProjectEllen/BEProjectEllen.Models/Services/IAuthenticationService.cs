using BEProjectEllen.Core.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Services
{
    public interface IAuthenticationService
    {
        Task<BearerToken> GenerateJWT(string name);
        Task<bool> Login(Login login);
    }
}