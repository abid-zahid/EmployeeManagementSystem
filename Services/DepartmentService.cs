using AutoMapper;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Repository;
using EmployeeManagementSystem.ViewModel;
using System.Diagnostics.CodeAnalysis;

namespace EmployeeManagementSystem.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<DepartmentViewModel>> GetAllAsync()
        {
           return _mapper.Map<IEnumerable<DepartmentViewModel>>( await _repository.GetAllAsync());
        }

        public async Task<DepartmentViewModel> GetAsync(Guid id)
        {
            var dep = await _repository.GetAsync(id);
            return _mapper.Map<DepartmentViewModel>(dep);
        }

        public async Task<DepartmentViewModel> SaveAsync(DepartmentViewModel department)
        {
            var dep = await _repository.SaveAsync(_mapper.Map<Department>(department));
            return _mapper.Map<DepartmentViewModel>(dep);
        }

        public async Task<DepartmentViewModel> UpdateAsync(DepartmentViewModel department)
        {
            var dep = await _repository.UpdateAsync(_mapper.Map<Department>(department));
            return _mapper.Map<DepartmentViewModel>(dep);
        }
    }
}