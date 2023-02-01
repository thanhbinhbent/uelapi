using Microsoft.AspNetCore.Mvc;
using UELStudents.Data;
using UELStudents.Models;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentDbContext _Context;

        public StudentsController(StudentDbContext context)
        {
            _Context = context;
        }
        //public static List<Course> courses = new List<Course>();
        [HttpGet("/api/student")]
        public IActionResult GetAll()
        {
            var listStudents = _Context.students.ToList();
            return Ok(listStudents);
        }
        [HttpGet("/api/student/{studentId}")]
        public IActionResult GetById(string studentId)
        {
            var listStudents = _Context.students.SingleOrDefault(list => list.Id == studentId
            );
            if (listStudents
                != null)
            {
                return Ok(listStudents);
            }
            else
            {
                return NotFound();
            }

        }
        
    }
}
