using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UELStudents.Data
{
    [Table("Tuition")]
    public class Tuition
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string TuitionId { get; set; }
        [ForeignKey("TuitionId")]
        public TuitionType TuitionType { get; set; }
        [Required]
        [MaxLength(10)]
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        public double AmountPaid { get; set; }
    }
}
