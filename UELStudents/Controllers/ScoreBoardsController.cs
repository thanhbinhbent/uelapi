using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Data;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreboardsController : ControllerBase
    {

        private readonly StudentDbContext _context;

        public ScoreboardsController(StudentDbContext context)
        {
            _context = context;
        }

        [HttpGet("/api/scoreboard/{studentId}")]
        public IActionResult GetScoreboardByStudentId(string studentId)
        {
            var scoreboard = (from score in _context.scores
                              join student in _context.students on score.StudentId equals student.Id
                              join course in _context.courses on score.CourseId equals course.Id
                              where student.Id == studentId
                              select new
                              {
                                  StudentId = score.StudentId,
                                  courseName = course.CourseName,
                                  score.Attendence,
                                  score.Midterm,
                                  score.Final,
                                  score.Advanced,
                                  score.PercentAttendence,
                                  score.PercentMidterm,
                                  score.PercentFinal,
                                  score.PercentAdvanced,
                                  score.StartYear,
                                  score.EndYear,
                                  score.Semester,
                                  course.Credit
                              }).ToList();

            if (scoreboard == null)
            {
                return NotFound();
            }

            return Ok(scoreboard);
        }
    }
}
