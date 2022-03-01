using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace wedding_planner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}
        [Required]
        public int UserId {get;set;}
        [Required]
        [MinLength(2)]
        public string WedderOne {get;set;}
        [Required]
        [MinLength(2)]
        public string WedderTwo {get;set;}
        [Required]
        public string Address {get;set;}
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}
        public User Creator {get;set;}
        public List<Association> Attendees {get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }
}