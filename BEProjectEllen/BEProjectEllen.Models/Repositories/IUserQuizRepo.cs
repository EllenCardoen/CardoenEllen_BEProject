using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public interface IUserQuizRepo : IGenericRepo<UserQuiz>
    {
        Task<UserQuiz> GetUserQuizByMaximumScore(int quizId, string userId);
    }
}
