using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UELStudents.Data
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }
        [Required]
        [MaxLength(100)] 
        public string CourseName { get; set; }
        [Required]
        public int Credit { get; set; }

    }
}
