using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UELStudents.Models;

namespace UELStudents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List <Student> students = new List<Student> ();
        [HttpGet]
        public IActionResult GetAll() // Kết quả trả về lên giao diện
        {
            return Ok(students); // Thành công sẽ trả về các danh sách hàng hoá

        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            var st = new Student()
            {
                Id = student.Id,
                Dob = student.Dob,
                Email = student.Email,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Major = student.Major,
                SelfEmail = student.SelfEmail,
                SelfPhone = student.SelfPhone,
                Town = student.Town,
                YearAdmission = student.YearAdmission
            };
            students.Add(st);
            return Ok(new
            {
                Success = true,
                Data = student
            }) ;
        }
        
    }
}
