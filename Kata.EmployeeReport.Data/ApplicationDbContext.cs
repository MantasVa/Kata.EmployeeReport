using Kata.EmployeeReport.Data.Infrastructure;
using Kata.EmployeeReport.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Kata.EmployeeReport.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(Configuration.DATABASE_PATH);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedEmployeeTable();
            base.OnModelCreating(modelBuilder);
        }
    }
}
