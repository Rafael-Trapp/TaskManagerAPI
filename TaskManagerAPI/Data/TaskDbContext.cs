using Microsoft.EntityFrameworkCore;
using Task = TaskManagerAPI.Models.Task;

namespace TaskManagerAPI.Data
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TaskDbContext(DbContextOptions<TaskDbContext> options) 
            : base(options) { }
    }
}
