using System;
using System.ComponentModel.DataAnnotations;

namespace review.Models
{
    public class LogUser
    {
        [Required]
        public string LogEmail {get;set;}
        [Required]
        
        public string LogPass {get;set;}


    }
}