using UELStudents.Models;

namespace UELStudents.Services
{
    public interface ICourseRespository
    {
        public List<CoursesVM> GetAll(string search);
    }
}
