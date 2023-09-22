using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetAsync(Guid id);
        Task<Employee> SaveAsync(Employee employee);
        Task<Employee> UpdateAsync(Employee employee);
        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<Employee>> GetAllAsync();
    }
}
