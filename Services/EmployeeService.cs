using AutoMapper;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Repository;
using EmployeeManagementSystem.ViewModel;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<EmployeeViewModel>>(await _repository.GetAllAsync());
        }

        public async Task<EmployeeViewModel> GetAsync(Guid id)
        {
            var emp = await _repository.GetAsync(id);
            return _mapper.Map<EmployeeViewModel>(emp);
        }

        public async Task<EmployeeViewModel> SaveAsync(EmployeeViewModel employee)
        {
            var emp = await _repository.SaveAsync(_mapper.Map<Employee>(employee));
            return _mapper.Map<EmployeeViewModel>(emp);
        }

        public async Task<EmployeeViewModel> UpdateAsync(EmployeeViewModel employee)
        {
            var emp = await _repository.UpdateAsync(_mapper.Map<Employee>(employee));
            return _mapper.Map<EmployeeViewModel>(emp);
        }
    }
}