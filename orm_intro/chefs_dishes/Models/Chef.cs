using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace chefs_dishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        [Required]
        [MinLength(3)]
        public string FirstName {get;set;}
        [Required]
        [MinLength(3)]
        public string LastName {get;set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Dish> Dishes {get;set;}
    }
}