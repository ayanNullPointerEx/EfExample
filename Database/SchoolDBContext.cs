using System;
using Domain;
using Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class SchoolDBContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        public SchoolDBContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseNpgsql(@"Host=localhost;Database=entitycore;Username=postgres;Password=password"); 
        }	
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }
    }
}