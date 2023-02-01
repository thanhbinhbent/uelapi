using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UELStudents.Data
{
    [Table("CoursesLine")]
    public class CourseLine
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        [MaxLength(10)]
        [Required]
        public string CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
  
        [Required]
        public int Semester { get; set; }
        [Required]
        [MaxLength(10)]
        public string TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }
        [Required]
        [MaxLength(4)]
        public int StartYear { get; set; }
        [Required]
        [MaxLength(4)]
        public int EndYear { get; set; }
    }
}
