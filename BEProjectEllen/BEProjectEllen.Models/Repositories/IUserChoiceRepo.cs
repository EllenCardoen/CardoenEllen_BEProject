using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public interface IUserChoiceRepo
    {
        Task<UserChoice> AddUserChoice(UserChoice userChoice);
    }
}