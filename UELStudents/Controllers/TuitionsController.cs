using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Models;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuitionsController : ControllerBase
    {
        public static List<Tuition> tuitions = new List<Tuition>();
        [HttpGet]
        public IActionResult GetAll() // Kết quả trả về lên giao diện
        {
            return Ok(tuitions); // Thành công sẽ trả về các danh sách

        }
        [HttpPost]
        public IActionResult Create(Tuition tuition)
        {
            var tuit = new Tuition()
            {
                Id = tuition.Id,
                StudentId = tuition.StudentId,
                Fees = tuition.Fees,
                TotalFees = tuition.TotalFees,
                Semester = tuition.Semester,
                StartYear = tuition.StartYear,
                EndYear = tuition.EndYear
            };
            tuitions.Add(tuit);
            return Ok(new
            {
                Success = true,
                Data = tuition
            });
        }
    }
}
