using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCKH.Models{
    public class Lecture{
        [Key]
        [Required]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public string Email { get; set; }
        public string Topic { get; set; }
    }
}