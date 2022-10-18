using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMySchedule.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Mobile { get; set; }
        public string Landline{ get; set; }
        [ForeignKey("Person")]
        public int IdPerson { get; set; }
        public Person Person { get; set; }

    }
}
