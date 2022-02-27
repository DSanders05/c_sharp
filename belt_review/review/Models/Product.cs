using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace review.Models
{
    public class Product
    {
        [Key]
        public int ProdId{get;set;}
        [Required]
        public string Name{get;set;}
        [Required]
        public string Picture {get;set;}
        [Required]
        [Range(0.01,1000000.00)]
        public double Price {get;set;}

        [Required]
        public int Quantity {get;set;}

        public int UserId {get;set;}

        public User Seller {get;set;}

        public List<Order> OrderedBy {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;
    }
}