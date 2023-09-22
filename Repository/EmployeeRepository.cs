using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var emp = await _context.Employees.FirstAsync(x => x.Id == id);
            emp.IsDeleted = true;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.Include(x => x.Department).ToListAsync();
        }

        public async Task<Employee> GetAsync(Guid id)
        {
            return await _context.Employees.Include(x => x.Department).FirstAsync(_ => _.Id == id);
        }

        public async Task<Employee> SaveAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateAsync(Employee employee)
        {
            employee.IsModified = true;
            employee.UpdatedAt = DateTime.UtcNow;
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            return employee;
        }
    }
}