using System.Collections.Generic;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public interface IQuizRepo
    {
        Task<Quiz> AddQuizAsync(Quiz quiz);
        Task DeleteQuiz(int id);
        Task<Quiz> GetQuizWithIdAsync(int id);
        Task<IEnumerable<Quiz>> GetQuizzesAsync();
    }
}