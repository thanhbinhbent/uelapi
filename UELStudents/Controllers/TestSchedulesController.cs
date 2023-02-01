using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Data;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestSchedulesController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public TestSchedulesController(StudentDbContext context)
        {
            _context = context;
        }

        [HttpGet("/api/testschedule/{studentId}")]
        public IActionResult GetTestScheduleByStudentId(string studentId)
        {
            var testSchedule = (from schedule in _context.testSchedules
                                join student in _context.students on schedule.StudentId equals student.Id
                                join course in _context.courses on schedule.CourseId equals course.Id
                                where student.Id == studentId
                                select new
                                {
                                    StudentId = studentId,
                                    course.CourseName,
                                    course.Credit,
                                    schedule.Date,
                                    schedule.Room,
                                    schedule.Time,
                                    schedule.EndYear,
                                    schedule.Semester,
                                    schedule.StartYear
                                }).ToList();

            if (testSchedule == null)
            {
                return NotFound();
            }

            return Ok(testSchedule);
        }
    }
}
