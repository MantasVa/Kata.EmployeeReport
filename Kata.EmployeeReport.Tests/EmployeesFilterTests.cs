using Kata.EmployeeReport.Data.Infrastructure.Interfaces;
using Kata.EmployeeReport.Data.Models;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Kata.EmployeeReport.Tests
{
    public class EmployeesFilterTests
    {
        [Fact]
        public void GetAdultEmployees_ReturnsEmployeesOver18()
        {
            var actualEmployees = GetEmployeesList().AsQueryable().GetAdultEmployees().ToList();

            Assert.Equal(7, actualEmployees.Count);
            foreach (var employee in actualEmployees)
            {
                Assert.True(employee.Age >= 18);
            }
        }

        [Fact]
        public void GetAdultEmployees_ReturnsEmployeesOrderedAscendingByName()
        {
            var actualEmployees = GetEmployeesList().AsQueryable().GetEmployeesOrderedByNameAsc().ToList();
            var expected = GetEmployeesList().OrderBy(x => x.Name).ToList();

            for (short i = 0; i < actualEmployees.Count; i++)
            {
                Assert.Equal(expected[i].Name, actualEmployees[i].Name);
            }
        }

        [Fact]
        public void GetAdultEmployees_ReturnsEmployeesOrderedDescendingByName()
        {
            var actualEmployees = GetEmployeesList().AsQueryable().GetEmployeesOrderedByNameDesc().ToList();
            var expected = GetEmployeesList().OrderByDescending(x => x.Name).ToList();

            for (short i = 0; i < actualEmployees.Count; i++)
            {
                Assert.Equal(expected[i].Name, actualEmployees[i].Name);
            }
        }

        [Fact]
        public void GetAdultEmployees_ReturnsAdultEmployeesInAlphabeticalOrder()
        {
            var actualEmployees = GetEmployeesList()
                .AsQueryable()
                .GetEmployeesOrderedByNameAsc()
                .GetAdultEmployees()
                .ToList();

            var expectedEmployees = GetEmployeesList().OrderBy(x => x.Name).ToList().Where(x => x.Age >= 18).ToList();
            Assert.Equal(expectedEmployees.Count, actualEmployees.Count);
            for (short i = 0; i < actualEmployees.Count; i++)
            {
                Assert.Equal(expectedEmployees[i].Name, actualEmployees[i].Name);
            }
        }

        public List<Employee> GetEmployeesList()
        {
            return new List<Employee>
            {
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
            };
        }
    }
}
