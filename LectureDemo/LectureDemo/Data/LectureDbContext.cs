using Microsoft.EntityFrameworkCore;

namespace LectureDemo.Data
{
    public class LectureDbContext : DbContext
    {
        public LectureDbContext(DbContextOptions<LectureDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
