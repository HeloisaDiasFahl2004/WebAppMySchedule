using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMySchedule.Models
{
    public class Address
    {
        [Key()]
        public int IdAddress { get; set; }  
        public string Street{ get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        [ForeignKey("Person")]
        public int IdPerson { get; set; }
        public Person Person { get; set; }

    }
}
