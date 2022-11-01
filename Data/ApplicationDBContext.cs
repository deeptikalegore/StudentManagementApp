using StudentManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentManagementApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options):base(options)
        {
          
        }
        public DbSet<Student> Students { get; set; }
    }
}