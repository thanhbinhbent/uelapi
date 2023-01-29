using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Models;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestSchedulesController : ControllerBase
    {
        public static List<TestSchedule> tests = new List<TestSchedule>();
        [HttpGet]
        public IActionResult GetAll() // Kết quả trả về lên giao diện
        {
            return Ok(tests); // Thành công sẽ trả về các danh sách

        }
        [HttpPost]
        public IActionResult Create(TestSchedule test)
        {
            var tst = new TestSchedule()
            {
                Id = test.Id,
                StudentId = test.StudentId,
                CourseId = test.CourseId,
                CourseName = test.CourseName,
                ExamDate = test.ExamDate,
                ExamTime = test.ExamTime,
                Location = test.Location,
                Semester = test.Semester,
                StartYear = test.StartYear,
                EndYear = test.EndYear
            };
            tests.Add(tst);
            return Ok(new
            {
                Success = true,
                Data = test
            });
        }
    }
}
