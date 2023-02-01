using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UELStudents.Data
{
    [Table("Score")]
    public class Score
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [Required]
        [MaxLength(10)]
        public string CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        public float Attendence { get; set; }
        [Required]
        public float Midterm { get; set; }
        [Required]
        public float Final { get; set; }
        public float Advanced { get; set; }
        [Required]
        public double PercentAttendence { get; set; }
        [Required]
        public double PercentMidterm { get; set; }
        [Required]
        public double PercentFinal { get; set; }
        [Required]
        public double PercentAdvanced { get; set; }
        [Required]
        [MaxLength(4)]
        public string StartYear { get; set; }
        [Required]
        [MaxLength(4)]
        public string EndYear { get; set; }
        [Required]
        public int Semester { get; set; } 



    }
}
