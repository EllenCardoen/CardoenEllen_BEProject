using System;
using System.Collections.Generic;
using System.Text;

namespace BEProjectEllen.Core.ViewModels
{
    public class UserVM
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> UserRoles { get; set; }
    }
}
