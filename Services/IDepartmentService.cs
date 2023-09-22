using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModel;

namespace EmployeeManagementSystem.Services
{
    public interface IDepartmentService
    {
        Task<DepartmentViewModel> GetAsync(Guid id);
        Task<DepartmentViewModel> SaveAsync(DepartmentViewModel department);
        Task<DepartmentViewModel> UpdateAsync(DepartmentViewModel department);
        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<DepartmentViewModel>> GetAllAsync();
    }
}
