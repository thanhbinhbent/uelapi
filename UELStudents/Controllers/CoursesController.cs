using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Models;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        public static List<Course> courses = new List<Course>();
        [HttpGet]
        public IActionResult GetAll() // Kết quả trả về lên giao diện
        {
            return Ok(courses); // Thành công sẽ trả về các danh sách

        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            var crs = new Course()
            {
                Id = course.Id,
                StudentId = course.StudentId,
                CourseId = course.CourseId,
                CourseName = course.CourseName,
                Credit = course.Credit,
                Grade = course.CourseName,
                TeacherId = course.TeacherId,
                Semester = course.Semester,
                StartYear = course.StartYear,
                EndYear = course.EndYear    
            };
            courses.Add(crs);
            return Ok(new
            {
                Success = true,
                Data = course
            });
        }
    }
}
