using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace Mission_08_group_1_1.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {

        }

        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Category> Catergories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CatergoryId = 1, CatergoryName = "Home" },
                new Category { CatergoryId = 2, CatergoryName = "School" },
                new Category { CatergoryId = 3, CatergoryName = "Work" },
                new Category { CatergoryId = 4, CatergoryName = "Church" }
                );

            mb.Entity<Tasks>().HasData(
                new Tasks
                {
                    Task = "Crisis",
                    CategoryId = 1,
                    DueDate = DateTime.Now,
                    Quadrant = 1,
                    Completed = false,
                    TaskId = 1
                },
                new Tasks
                {
                    Task = "Recreation",
                    CategoryId = 1,
                    DueDate = DateTime.Now,
                    Quadrant = 2,
                    Completed = false,
                    TaskId = 2
                },
                new Tasks
                {
                    Task = "Interruptions",
                    CategoryId = 3,
                    DueDate = DateTime.Now,
                    Quadrant = 3,
                    Completed = false,
                    TaskId = 3
                },
                new Tasks
                {
                    Task = "Time Wasters",
                    CategoryId = 3,
                    DueDate = DateTime.Now,
                    Quadrant = 4,
                    Completed = false,
                    TaskId = 4
                }
            );
        }
    }

}