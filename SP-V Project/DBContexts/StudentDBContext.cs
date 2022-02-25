using Microsoft.EntityFrameworkCore;
using SP_V_Project.Models;

namespace SP_V_Project.DBContexts
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext>options)
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
