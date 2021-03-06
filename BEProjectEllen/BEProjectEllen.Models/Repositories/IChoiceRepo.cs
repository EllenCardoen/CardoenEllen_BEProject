﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public interface IChoiceRepo : IGenericRepo<Choice>
    {
        Task<IEnumerable<Choice>> GetCorrectChoiceByQuiz(int id);
    }
}
