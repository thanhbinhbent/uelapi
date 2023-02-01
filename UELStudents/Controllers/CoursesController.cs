using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using UELStudents.Data;
using UELStudents.Models;
using Course = UELStudents.Data.Course;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    { 
        private readonly StudentDbContext _context;

        public CoursesController(StudentDbContext context)
        {
            _context = context;
        }
        [HttpGet("/api/course")]
        public IActionResult GetAll()
        {
            var listCourse = _context.courses.ToList();
            return Ok(listCourse);
        }
        [HttpGet("/api/course/{studentId}")]
        public IActionResult GetById(string studentId)
        {
            var schedules = (from courseLine in _context.courseLines
                             join course in _context.courses on courseLine.CourseId equals course.Id
                             join student in _context.students on courseLine.StudentId equals student.Id
                             join teacher in _context.teachers on courseLine.TeacherId equals teacher.Id
                             where student.Id == studentId
                             select new
                             {
                                 StudentId = courseLine.StudentId,
                                 CourseId = course.Id,
                                 courseName = course.CourseName,
                                 TeacherName = teacher.TeacherName,
                                 Semester = courseLine.Semester,
                                 StartYear = courseLine.StartYear,
                                 EndYear = courseLine.EndYear,
                             }).ToList();

            if (schedules == null)
            {
                return NotFound();
            }

            return Ok(schedules);

        }
      

        
    }
}
