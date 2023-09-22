using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModel;

namespace EmployeeManagementSystem.Services
{
    public interface IEmployeeService
    {
        Task<EmployeeViewModel> GetAsync(Guid id);
        Task<EmployeeViewModel> SaveAsync(EmployeeViewModel employee);
        Task<EmployeeViewModel> UpdateAsync(EmployeeViewModel employee);
        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<EmployeeViewModel>> GetAllAsync();
    }
}
