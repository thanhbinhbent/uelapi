namespace UELStudents.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public string Grade { get; set; }

        public int TeacherId { get; set; }


        public int Semester { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }

    }
}
