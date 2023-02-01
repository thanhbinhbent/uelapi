using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Data;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class activityScoreController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public activityScoreController(StudentDbContext context)
        {
            _context = context;
        }

        [HttpGet("/api/activityscore/{studentId}")]
        public IActionResult GetActivityScoreByStudentId(string studentId)
        {
            var activityScore = (from score in _context.scoresactivity
                                 join student in _context.students on score.StudentId equals student.Id
                                 where student.Id == studentId
                                 select new
                                 {
                                     StudentId = score.StudentId,
                                     score.StartYear,
                                     score.EndYear,
                                     score.Semester,
                                     score.Score
                                 }).ToList();

            if (activityScore == null)
            {
                return NotFound();
            }

            return Ok(activityScore);
        }
    }
}
