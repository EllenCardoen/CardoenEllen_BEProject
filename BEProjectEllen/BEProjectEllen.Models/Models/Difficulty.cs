using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BEProjectEllen.Core
{
    public class Difficulty
    {
        public int Id { get; set; }

        [Required]
        public string Level { get; set; }
    }
}
