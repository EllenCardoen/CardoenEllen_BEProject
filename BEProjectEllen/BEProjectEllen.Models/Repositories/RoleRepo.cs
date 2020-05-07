using BEProjectEllen.Core.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Core.Repositories
{
    public class RoleRepo : GenericRepo<IdentityRole>, IRoleRepo
    {
        private readonly QuizDBContext _context;

        public RoleRepo(QuizDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
