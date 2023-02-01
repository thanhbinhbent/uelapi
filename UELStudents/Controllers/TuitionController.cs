using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Data;
using UELStudents.Models;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuitionController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public TuitionController(StudentDbContext context)
        {
            _context = context;
        }

        [HttpGet("/api/tuition/{studentId}")]
        public IActionResult GetTuition(string studentId)
        {
     

            var tuitionsList =
                (from tuition in _context.tuitions
                 join student in _context.students on tuition.StudentId equals student.Id
                 join tuitionType in _context.tuitionTypes on tuition.TuitionId equals tuitionType.Id
                 where student.Id == studentId
                 select new 
                          {
                              StudentId = student.Id,
                              TuitionName = tuitionType.TuitionName,
                              Amount = tuitionType.Amount,
                              AmountPaid = tuition.AmountPaid,
                              Semester = tuitionType.Semester,
                              StartYear = tuitionType.StartYear,
                              EndYear = tuitionType.EndYear
                          }).ToList();
            if (tuitionsList == null)
            {
                return NotFound();
            }
            return Ok(tuitionsList);
        }
    }
}
