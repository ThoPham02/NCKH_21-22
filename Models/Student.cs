using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCKH.Models{
    public class Student{
        [Key]
        [Required]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}