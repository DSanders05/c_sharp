using System;
using System.ComponentModel.DataAnnotations;

namespace mvcDemo.Models
{
    public class Pet
    {
        [Required]
        [MinLength(2)]
        public string petName {get;set;}

        [Required]
        [MinLength(2)]

        public string petType {get;set;}

        [Required]
        [Range(0,25)]
        public int petAge {get;set;}

        [Required]
        public string petColor {get;set;}
    }
}