using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Models;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreBoardsController : ControllerBase
    {
        public static List<ScoreBoard> scores = new List<ScoreBoard>();
        [HttpGet]
        public IActionResult GetAll() // Kết quả trả về lên giao diện
        {
            return Ok(scores); // Thành công sẽ trả về các danh sách

        }
        [HttpPost]
        public IActionResult Create(ScoreBoard score)
        {
            var sc = new ScoreBoard()
            {
                Id = score.Id,
                StudentId = score.StudentId,
                CourseId = score.CourseId,
                Attendance = score.Attendance,
                Midterm = score.Midterm,
                Final = score.Final,
                Advanced = score.Advanced
            };
            scores.Add(sc);
            return Ok(new
            {
                Success = true,
                Data = score
            });
        }
    }
}
