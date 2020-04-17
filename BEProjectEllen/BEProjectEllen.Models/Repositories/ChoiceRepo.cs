using BEProjectEllen.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public class ChoiceRepo : GenericRepo<Choice>, IChoiceRepo
    {
        private readonly QuizDBContext _context;

        public ChoiceRepo(QuizDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Choice>> GetCorrectChoiceByQuiz(int id)
        {
            return await _context.Choices
                .Include(c => c.Question)               
                .Where(c => c.Question.QuizId == id)
                .Where( c => c.IsCorrect )
                .ToListAsync();
        }
    }
}
