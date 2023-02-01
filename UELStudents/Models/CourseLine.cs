namespace UELStudents.Models
{
    public class CourseLine
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public string Grade { get; set; }
        public int TeacherId { get; set; }
        public int Semester { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }

    }
    public class CoursesVM
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public string Grade { get; set; }
        public string TeacherName { get; set; }
        public int Semester { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
