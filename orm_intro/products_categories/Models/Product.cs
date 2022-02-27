using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace products_categories.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Desc {get;set;}
        [Required]
        public double Price {get;set;}

        public List<Association> Categories {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;
    }
}