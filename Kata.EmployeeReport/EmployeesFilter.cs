using Kata.EmployeeReport.Data.Infrastructure.Interfaces;
using Kata.EmployeeReport.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata.EmployeeReport
{
    public static class EmployeesFilter
    {

        public static IQueryable<Employee> GetAdultEmployees(this IQueryable<Employee> employees)
        {
            return employees.Where(em => em.Age >= 18);
        }

        public static IQueryable<Employee> GetEmployeesOrderedByNameAsc(this IQueryable<Employee> employees)
        {
            return employees.OrderBy(x => x.Name);
        }

        public static IQueryable<Employee> GetEmployeesOrderedByNameDesc(this IQueryable<Employee> employees)
        {
            return employees.OrderByDescending(x => x.Name);
        }
    }
}
