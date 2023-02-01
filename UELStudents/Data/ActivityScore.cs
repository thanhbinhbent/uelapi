using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UELStudents.Data
{
    [Table("ActivityScore")]
    public class ActivityScore
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
        [MaxLength(4)]
        public int StartYear { get; set; }
        [Required]
        [MaxLength(4)]
        public int EndYear { get; set; }
        [Required]
        public int Semester { get; set; }
        [Required]
        public int Score { get; set; }  


    }
}
