namespace UELStudents.Models
{
    public class ScoreBoard
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int CourseId { get; set; }
        public float Attendance { get; set; }
        public float Midterm { get; set; }
        public float Final { get; set; }
        public float Advanced { get; set; }
    }
}
