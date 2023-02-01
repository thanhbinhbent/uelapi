using UELStudents.Data;
using UELStudents.Models;

namespace UELStudents.Services
{
    public class CourseRespository : ICourseRespository
    {
        private readonly StudentDbContext _context;

        public CourseRespository(StudentDbContext context)
        {
            _context = context; 
        }
        public List<CoursesVM> GetAll(string search)
        {
            throw new NotImplementedException();
        }
    }
}
