using System;
using System.ComponentModel.DataAnnotations;

namespace random_passcode.Models
{
    public class Code
    {
        [Required]
        [MinLength(14)]
        public string passCode {get;set;}
    }
}