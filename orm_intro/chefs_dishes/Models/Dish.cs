using System;
using System.ComponentModel.DataAnnotations;

namespace chefs_dishes.Models
{
    public class Dish
    {
        [Key]
        [Required]
        public int DishId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        [Range(1,5)]
        public int Tastiness {get;set;}
        [Required]
        [Range(0,9999)]
        public int Calories {get;set;}
        [Required]
        public string Description {get;set;}
        public int ChefId {get;set;}
        public Chef Creator {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}