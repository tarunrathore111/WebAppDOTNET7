using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q9CS2A9\\SQLEXPRESS;Initial Catalog=DatabaseAutomated;Integrated Security=True; TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee
        //        {
        //            Id = 1,
        //            Name = "Tarun",
        //            Email = "Tarun@gmail.com",
        //            Department = "IT",
        //        });
        //}
    }
}
