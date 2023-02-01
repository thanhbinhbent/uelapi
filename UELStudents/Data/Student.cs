using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UELStudents.Data
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string Dob { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        public string Major { get; set; }
        public string SelfEmail { get; set; }
        public string SelfPhone
        { get; set; }
        [Required]
        public string Town { get; set; }
        [Required]
        [MaxLength(4)]
        public int YearAdmission { get; set; }
    }
}
