using BEProjectEllen.Core.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public class UserRepo : GenericRepo<IdentityUser>,IUserRepo
    {
        private readonly QuizDBContext _context;

        public UserRepo(QuizDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
