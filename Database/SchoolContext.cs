using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        public SchoolContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseNpgsql(@"Host=localhost;Database=entitycore;Username=postgres;Password=password"); 

        }
    }
}