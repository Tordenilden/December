using December.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace December.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        //public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        // here are out tables presented as DbSet<T>
        public DbSet<Person> Persons { get; set; }
        public DbSet<Houses> Houses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Constraints 
            base.OnModelCreating(modelBuilder);
            // Seed Houses
            modelBuilder.Entity<Houses>().HasData(
                new Houses { Id = 1, Name = "North House", Region = "North" },
                new Houses { Id = 2, Name = "South House", Region = "South" }
            );

            // Seed Persons m - 1 relationship
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "John", Lastname = "Doe", Mail = "john@example.com"},
                new Person { Id = 2, Name = "Jane", Lastname = "Smith", Mail = "jane@example.com" }
            );


        }
    }
}
