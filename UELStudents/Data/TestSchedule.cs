using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UELStudents.Data
{
    [Table("TestSchedule")]
    public class TestSchedule
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }
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
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(10)]
        public string Room { get; set; }
        [Required]
        [MaxLength(10)]
        public string Time { get; set; }
        [Required]
        public int Semester { get; set; }
        [Required]
        [MaxLength(4)]
        public int StartYear { get; set; }
        [Required]
        [MaxLength(4)]
        public int EndYear { get; set; }


    }

}
