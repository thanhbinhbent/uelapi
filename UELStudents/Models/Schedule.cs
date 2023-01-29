namespace UELStudents.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime Date { get; set; }
        public string Period { get; set; }
        public string Room { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TeacherId { get; set; }
      public string  TeacherName { get; set; }
        public string TimeFormat { get; set; }
    }
}
