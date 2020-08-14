using Kata.EmployeeReport.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace Kata.EmployeeReport.Data.Infrastructure
{
    public static class SeedDatabase
    {
        public static void SeedEmployeeTable(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mantas",
                    Age = 21
                },
                new Employee
                {
                    Id = 2,
                    Name = "Rutenis",
                    Age = 22
                },
                new Employee
                {
                    Id = 3,
                    Name = "Aidanas",
                    Age = 27
                },
                new Employee
                {
                    Id = 4,
                    Name = "Arturas",
                    Age = 32
                },
                new Employee
                {
                    Id = 5,
                    Name = "Max",
                    Age = 17
                },
                new Employee
                {
                    Id = 6,
                    Name = "Sepp",
                    Age = 18
                },
                new Employee
                {
                    Id = 7,
                    Name = "Nina",
                    Age = 15
                },
                new Employee
                {
                    Id = 8,
                    Name = "Mike",
                    Age = 51
                },
                new Employee
                {
                    Id = 9,
                    Name = "Lebionka",
                    Age = 19
                },
                new Employee
                {
                    Id = 10,
                    Name = "Artur",
                    Age = 14
                }
            );
        }
    }
}
