using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;

namespace CodeFirst
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Data Source=HASNAA-ABDELRAH;Initial Catalog=HealthAppv2;;Integrated Security=True;TrustServerCertificate=True");
        // 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserHealth>().HasNoKey();

        }
        public DbSet<User> Users { get; set; }
        public DbSet <UserHealth> UsersHealth { get; set; }
        public DbSet <Authentication> Authentication { get; set; }
        public DbSet<Sleep> Sleep { get; set; }
        public DbSet<Daily> Daily { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Meal> Meals { get; set; }



    }
}
