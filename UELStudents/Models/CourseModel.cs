using System.ComponentModel.DataAnnotations;

namespace UELStudents.Models
{
    public class CourseModel
    {
       public string Id { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public int Semester { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
