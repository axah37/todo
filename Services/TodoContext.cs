using System;
using Microsoft.EntityFrameworkCore;
namespace todoApp{
    public class TodoContext:DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public TodoContext()
        {
            
        }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Database=todo"
            )
            .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }
    }
}