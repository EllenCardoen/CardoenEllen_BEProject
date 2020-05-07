using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BEProjectEllen.Core.ViewModels
{
    public class UserManagerVM
    {
        public IEnumerable<IdentityRole> Roles { get; set; }
        public List<UserVM> UserVMS { get; set; }
    }
}
