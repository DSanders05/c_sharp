using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace review.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Location {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;

        // For the one to many, one user has inventory of products they are selling
        public List<Product> Inventory {get;set;}

        public List<Order> MyOrders {get;set;}

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PassConfirm {get;set;}
    }
}