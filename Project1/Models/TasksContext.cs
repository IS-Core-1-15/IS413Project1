using System;
using Microsoft.EntityFrameworkCore;

namespace Project1.Models
{
    public class TasksContext : DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options) : base(options)
        {

        }

        public DbSet<TasksModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TasksModel>().HasData(
                new TasksModel {
                    TaskID = 1,
                    Task = "Make the database",
                    Date = DateTime.UtcNow,
                    Quadrant = 1,
                    Category = "School",
                    Completed = true
                },

                new TasksModel
                {
                    TaskID = 2,
                    Task = "Make the Shared Layout",
                    Date = DateTime.UtcNow,
                    Quadrant = 2,
                    Category = "Home",
                    Completed = false
                },

                new TasksModel
                {
                    TaskID = 3,
                    Task = "Make the quadrant views",
                    Date = DateTime.UtcNow,
                    Quadrant = 3,
                    Category = "Work",
                    Completed = false
                },

                new TasksModel
                {
                    TaskID = 4,
                    Task = "Make the Controllers",
                    Date = DateTime.UtcNow,
                    Quadrant = 4,
                    Category = "Church",
                    Completed = false
                }
            );
        }
    }
}
