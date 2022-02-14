using System;
using System.ComponentModel.DataAnnotations;

namespace dojo_survey_mvc.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2, ErrorMessage ="Name field must be at least two characters long.")]
        public string name {get;set;}

        [Required]
        [MinLength(2, ErrorMessage ="Location field must be at least two characters long.")]
        public string location {get;set;}

        [Required]
        [MinLength(2, ErrorMessage ="Language field must be at least two characters long.")]
        public string language {get;set;}


        [MaxLength(20)]
        public string commentSection {get;set;}
    }
}