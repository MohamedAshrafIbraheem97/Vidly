using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte membershipTypeId { get; set; }
        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}