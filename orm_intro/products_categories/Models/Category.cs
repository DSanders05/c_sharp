using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace products_categories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {get;set;}
        [Required]
        [MinLength(4)]
        public string Name{get;set;}
        public List<Association> Products {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;
    }
}