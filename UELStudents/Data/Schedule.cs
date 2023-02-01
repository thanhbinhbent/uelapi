using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UELStudents.Data
{
    [Table("Schedule")]
    public class Schedule
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }
        [Required]
        [MaxLength(15)]
        public DateTime Datetime { get; set; }
        [Required]
        [MaxLength(10)]
        public string CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        [Required]
        [MaxLength(10)]
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        [Required]
        [MaxLength(10)]
        public string Room { get; set; }
        [Required]
        [MaxLength(10)]
        public string TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }

        [Required]
        [MaxLength(10)]
        public string TimeStart { get; set; }
        [Required]
        [MaxLength(10)]
        public string TimeEnd { get; set; }
        [Required]
        [MaxLength(2)]
        public string TimeFormat { get; set; }
    }
}
