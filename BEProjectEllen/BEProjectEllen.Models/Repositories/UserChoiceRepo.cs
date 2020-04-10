using BEProjectEllen.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public class UserChoiceRepo : IUserChoiceRepo
    {
        //Add userchoice
        private readonly QuizDBContext _context;

        public UserChoiceRepo(QuizDBContext context)
        {
            this._context = context;
        }

        public async Task<UserChoice> AddUserChoice(UserChoice userChoice)
        {
            try
            {
                var result = _context.UserChoices.AddAsync(userChoice);
                await _context.SaveChangesAsync();
                return userChoice;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return null;
            }
        }
    }
}
