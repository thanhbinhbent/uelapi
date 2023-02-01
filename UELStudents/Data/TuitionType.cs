using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UELStudents.Data
{
    [Table("TuitionType")]
    public class TuitionType
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string TuitionName { get; set; }
        [Required]
        public double Amount { get; set; }
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
