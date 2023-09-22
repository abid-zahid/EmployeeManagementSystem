using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Repository
{
    public interface IDepartmentRepository
    {
        Task<Department> GetAsync(Guid id);
        Task<Department> SaveAsync(Department department);
        Task<Department> UpdateAsync(Department department);
        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<Department>> GetAllAsync();

    }
}
