using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Models;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
        public static List<Schedule> schedules = new List<Schedule>();
        [HttpGet]
        public IActionResult GetAll() // Kết quả trả về lên giao diện
        {
            return Ok(schedules); // Thành công sẽ trả về các danh sách

        }
        [HttpPost]
        public IActionResult Create(Schedule schedule)
        {
            var sch = new Schedule()
            {
                Id = schedule.Id,
                StudentId = schedule.StudentId,
                CourseId = schedule.CourseId,
                Date = schedule.Date,
                Period = schedule.Period,
                Room = schedule.Room,                
                StartTime = schedule.StartTime,
                EndTime = schedule.EndTime,
                TeacherId = schedule.TeacherId,
                TimeFormat = schedule.TimeFormat,
            };
            schedules.Add(sch);
            return Ok(new
            {
                Success = true,
                Data = schedule
            });
        }

    }
}
