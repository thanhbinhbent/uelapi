using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UELStudents.Data
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string TeacherName { get; set; }
        [Required]
        public int Gender { get; set; }
        [Required]
        [MaxLength(100)]
        public string Faculity { get; set; }

    }
}
