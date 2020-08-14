using Kata.EmployeeReport.Data.Infrastructure.Extensions;
using Kata.EmployeeReport.Data.Infrastructure.Interfaces;
using Kata.EmployeeReport.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata.EmployeeReport.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Employee>> GetAllAsync() => await _context.Employees.ToListAsync();
        public async Task<Employee> GetPersonById(int id) => await _context.Employees.Where(p => p.Id == id).FirstOrDefaultAsync();
        public async Task AddAsync(Employee employee)
        {
            employee.Name = employee.Name.ToUpperFirstLetter();
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }
        public async Task Remove(Employee employee)
        {
            var dbEntry = await GetPersonById(employee.Id);
            _context.Employees.Remove(dbEntry);
        }
    }
}
