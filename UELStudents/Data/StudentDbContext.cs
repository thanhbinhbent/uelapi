using Microsoft.EntityFrameworkCore;

namespace UELStudents.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options) { }

        #region Dbset
        public DbSet<Student> students { get; set; } // tập dữ liệu student có thể lấy ra để xử lý thêm xoá sửa
        public DbSet<CourseLine> courseLines { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Schedule> schedules { get; set; }
        public DbSet<Score> scores { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<TestSchedule> testSchedules { get; set; }
        public DbSet<Tuition> tuitions { get; set; }
        public DbSet<TuitionType> tuitionTypes { get; set; }
        public DbSet<ActivityScore> scoresactivity { get; set; }


        #endregion
    }
}
