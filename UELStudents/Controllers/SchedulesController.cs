using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Data;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {

        private readonly StudentDbContext _context;

        public SchedulesController(StudentDbContext context)
        {
            _context = context;
        }

        [HttpGet("/api/schedule/{studentId}")]
        public IActionResult GetSchedulesByStudentId(string studentId)
        {
            var schedules = (from schedule in _context.schedules
                             join student in _context.students on schedule.StudentId equals student.Id
                             join course in _context.courses on schedule.CourseId equals course.Id
                             join teacher in _context.teachers on schedule.TeacherId equals teacher.Id
                             where student.Id == studentId
                             select new
                             {
                                 StudentId = schedule.StudentId,
                                 DateTime = schedule.Datetime,
                                 courseName = course.CourseName,
                                 Room = schedule.Room,
                                 teacher.Gender,
                                 TeacherName = teacher.TeacherName,
                                 TimeStart = schedule.TimeStart,
                                 TimeEnd = schedule.TimeEnd,
                                 TimeFormat = schedule.TimeFormat
                             }).ToList();

            if (schedules == null)
            {
                return NotFound();
            }

            return Ok(schedules);
        }
    }
}
