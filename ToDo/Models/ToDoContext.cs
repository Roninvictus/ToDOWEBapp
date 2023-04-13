using System;
using Microsoft.EntityFrameworkCore;

namespace ToDo.Models
{
	public class ToDoContext : DbContext
    {
		public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

		public DbSet<ToDo> ToDos => Set<ToDo>();

      

        //seed data

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().HasData(
                new ToDo { Id = 1, Description = "Finish Web assignment", Title = "ToDo assignment", Completed = true },
                new ToDo { Id = 2, Description = "Finish ios assignment", Title = "ios assignment", Completed = false },
                new ToDo { Id = 3, Description = "Finish kotlin assignment", Title = "kotlin assignment", Completed = false },
                new ToDo { Id = 4, Description = "Finish DBA assignment", Title = "DBA assignment", Completed = true }
            );
               
        }

    }
}


