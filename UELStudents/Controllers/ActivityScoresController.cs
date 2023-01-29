using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Models;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityScoresController : ControllerBase
    {
        public static List<ActivityScore> scores = new List<ActivityScore>();
        [HttpGet]
        public IActionResult GetAll() // Kết quả trả về lên giao diện
        {
            return Ok(scores); // Thành công sẽ trả về các danh sách

        }
        [HttpPost]
        public IActionResult Create(ActivityScore score)
        {
            var scr = new ActivityScore()
            {
                Id = score.Id,
                StudentId = score.StudentId,
                Score = score.Score,
                Semester = score.Semester,
                StartYear = score.StartYear,
                EndYear = score.EndYear
            };
            scores.Add(scr);
            return Ok(new
            {
                Success = true,
                Data = score
            });
        }
    }
}
