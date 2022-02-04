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

        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<CategoryModel> ().HasData(
                new CategoryModel
                {
                    CategoryID = 1,
                    CategoryName = "School"
                },

                new CategoryModel
                {
                    CategoryID = 2,
                    CategoryName = "Work"
                },

                new CategoryModel
                {
                    CategoryID = 3,
                    CategoryName = "Home"
                },

                new CategoryModel
                {
                    CategoryID = 4,
                    CategoryName = "Church"
                }

            );

            mb.Entity<TasksModel>().HasData(
                new TasksModel {
                    TaskID = 1,
                    Task = "Make the database",
                    Date = DateTime.UtcNow,
                    Quadrant = 1,
                    CategoryID = 1,
                    Completed = true
                },

                new TasksModel
                {
                    TaskID = 2,
                    Task = "Make the Shared Layout",
                    Date = DateTime.UtcNow,
                    Quadrant = 2,
                    CategoryID = 3,
                    Completed = false
                },

                new TasksModel
                {
                    TaskID = 3,
                    Task = "Make the quadrant views",
                    Date = DateTime.UtcNow,
                    Quadrant = 3,
                    CategoryID = 4,
                    Completed = false
                },

                new TasksModel
                {
                    TaskID = 4,
                    Task = "Make the Controllers",
                    Date = DateTime.UtcNow,
                    Quadrant = 4,
                    CategoryID = 5,
                    Completed = false
                }
            );
        }
    }
}
