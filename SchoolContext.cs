using System.Data.Entity;

namespace CodeFirstStudentApp
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
