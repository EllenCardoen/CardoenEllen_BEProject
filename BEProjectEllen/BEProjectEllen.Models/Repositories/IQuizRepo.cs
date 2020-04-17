using System.Collections.Generic;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public interface IQuizRepo:IGenericRepo<Quiz>
    {
        void AddUserQuiz(UserQuiz userQuiz);
    }
}