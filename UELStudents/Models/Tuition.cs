namespace UELStudents.Models
{
    public class Tuition
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public List<Fee> Fees { get; set; }
        public float TotalFees { get; set; }
        public int Semester { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }

    public class Fee
    {
        public string Type { get; set; }
        public float Amount { get; set; }
    }
}
