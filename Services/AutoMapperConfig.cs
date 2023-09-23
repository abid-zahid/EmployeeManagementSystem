using AutoMapper;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModel;

namespace EmployeeManagementSystem.Services
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department.DepartmentName));
            CreateMap<EmployeeViewModel, Employee>()
                .ForMember(dest => dest.Department, opt => opt.Ignore());
            CreateMap<Department, DepartmentViewModel>().ReverseMap();
        }
    }
}
