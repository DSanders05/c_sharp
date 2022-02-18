using System;
using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Models
{
    public class Icecream
    {
        // Key is required because we need a primary key in MySQL
        [Key]
        [Required]
        public int IcecreamId {get;set;}

        //Here are our attributes
        [Required]
        public string Flavor {get;set;}
        [Required]
        public string Topping {get;set;}
        [Required]
        public bool hasCherry {get;set;}
        [Required]
        public string Container {get;set;}

        //don't forget created at and updated at
        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}