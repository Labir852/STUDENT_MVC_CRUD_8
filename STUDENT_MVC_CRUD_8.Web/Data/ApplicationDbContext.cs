using Microsoft.EntityFrameworkCore;
using STUDENT_MVC_CRUD_8.Web.Models.Entities;

namespace STUDENT_MVC_CRUD_8.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }

    }
}
