using Microsoft.EntityFrameworkCore;

namespace TestApp1.Models
{
    public class TasksDbContext:DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options):base (options)
        {
           
        }
        public DbSet<Tasks> Tasks { get; set; }
    }
}
