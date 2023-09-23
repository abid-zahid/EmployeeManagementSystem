using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeDbContext _context;

        public DepartmentRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var dep = await _context.Departments.FirstAsync(x => x.Id == id);
            dep.IsDeleted = true;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Department>> GetAllAsync()
        {
            return await _context.Departments.Where(x => !x.IsDeleted).ToListAsync();
        }

        public async Task<Department> GetAsync(Guid id)
        {
            return await _context.Departments.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }

        public async Task<Department> SaveAsync(Department department)
        {
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();
            return department;
        }

        public async Task<Department> UpdateAsync(Department department)
        {
            department.IsModified = true;
            department.UpdatedAt = DateTime.Now;
            _context.Departments.Update(department);
            await _context.SaveChangesAsync();
            return department;
        }
    }
}