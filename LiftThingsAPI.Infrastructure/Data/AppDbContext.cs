using System;
using LiftThingsAPI.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LiftThingsAPI.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Routine> Routines { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Set> Sets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // use Sqlite db
            optionsBuilder.UseSqlite("Data Source = ../LiftThingsAPI.Infrastructure/ExerciseLog.db");
        }
    }
}
