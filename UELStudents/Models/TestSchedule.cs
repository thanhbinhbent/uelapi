namespace UELStudents.Models
{
    public class TestSchedule
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime ExamDate { get; set; }
        public string ExamTime { get; set; }
        public string Location { get; set; }
        public int Semester { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
