using System;
using System.ComponentModel.DataAnnotations;

namespace wedding_planner.Models
{
    public class Association
    {
        [Key]
        public int AssociationId {get;set;}
        public int WeddingId {get;set;}
        public int UserId {get;set;}

        public Wedding Weddings {get;set;}
        public User Attendee {get;set;}
    }
}