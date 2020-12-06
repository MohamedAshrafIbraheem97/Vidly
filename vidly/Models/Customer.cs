﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public bool IsSubscribedToNewsLetter { get; set; }
        
        public MembershipType MembershipType { get; set; }
        
        [Display(Name= "Membership Type")]
        public byte membershipTypeId { get; set; }
        [Min18YearsIfAMember]
        [Display(Name = "Date of birth")]
        public DateTime? Birthdate { get; set; }
    }
}