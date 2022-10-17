using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppMySchedule.Models
{
    public class Person
    {
        [Key()]
        public int IdPerson { get; set; }
        public string Name{ get; set; }
        public DateTime Birthday{ get; set; }
        public string Phone { get; set; }
        public virtual List<Address> Address { get; set; }
    }
}
