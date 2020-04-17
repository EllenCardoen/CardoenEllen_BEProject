using System.Collections.Generic;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Services
{
    public interface IQuizService
    {
        Task<UserQuiz> SaveUserQuiz(List<int> choices, int id, string userId);
    }
}