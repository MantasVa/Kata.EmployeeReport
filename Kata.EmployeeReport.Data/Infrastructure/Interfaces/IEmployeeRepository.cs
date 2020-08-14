using Kata.EmployeeReport.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kata.EmployeeReport.Data.Infrastructure.Interfaces
{
    public interface IEmployeeRepository
    {
        Task AddAsync(Employee employee);
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetPersonById(int id);
        Task Remove(Employee employee);
    }
}