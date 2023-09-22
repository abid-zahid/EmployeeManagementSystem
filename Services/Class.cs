using AutoMapper;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModel;

namespace EmployeeManagementSystem.Services
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
            CreateMap<Department, DepartmentViewModel>().ReverseMap();
        }
    }
}
