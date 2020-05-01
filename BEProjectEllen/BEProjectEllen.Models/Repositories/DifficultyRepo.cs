using BEProjectEllen.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public class DifficultyRepo : GenericRepo<Difficulty>, IDifficultyRepo
    {
        public DifficultyRepo(QuizDBContext context) : base(context)
        {

        }

     
    }
}
