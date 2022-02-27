using System;
using System.ComponentModel.DataAnnotations;

namespace review.Models
{
    public class Order
    {
        [Key]
        public int OrderId {get;set;}
        public int UserId {get;set;}
        public User User {get;set;}

        public int ProductId {get;set;}
        public Product Product {get;set;}

        public int Quantity {get;set;}
    }
}