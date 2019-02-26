using System;
using Microsoft.EntityFrameworkCore;

namespace DockerTest.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    LastName = "Doe",
                    FirstName = "John",
                    Birthdate = new DateTime(1980, 04, 20)
                },
                new User
                { 
                    Id = 2,
                    LastName = "Doe",
                    FirstName = "Jane",
                    Birthdate = new DateTime(1970, 02, 10)
                }
            );
        }
    }
}