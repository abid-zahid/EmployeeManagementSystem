using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.ViewModel;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        public async Task<ActionResult> Index([DataSourceRequest] DataSourceRequest request)
        {
            await PopulateDepartmentsAsync();
            return View();
        }
        public async Task<ActionResult> EmployeeListAsync([DataSourceRequest] DataSourceRequest request)
        {
            var employees = await _employeeService.GetAllAsync();

            var response = employees.ToDataSourceResult(request);
            return Json(response);
        }

        [AcceptVerbs("Post")]
        public async Task<ActionResult> UpdateEmployeeAsync([DataSourceRequest] DataSourceRequest request, EmployeeViewModel employee)
        {
            var result = new List<EmployeeViewModel>();
            if(employee != null && ModelState.IsValid)
            {
                await _employeeService.UpdateAsync(employee);
               result = (await _employeeService.GetAllAsync()).ToList();
            }
            return Json(result.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs("Post")]
        public async Task<ActionResult> CreateEmployeeAsync([DataSourceRequest] DataSourceRequest request, EmployeeViewModel employee)
        {
            var result = new List<EmployeeViewModel>();
            if (employee != null && ModelState.IsValid)
            {
                await _employeeService.SaveAsync(employee);
                result = (await _employeeService.GetAllAsync()).ToList();
            }
            return Json(result.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs("Post")]
        public async Task<ActionResult> DeleteEmployeeAsync([DataSourceRequest] DataSourceRequest request,  EmployeeViewModel employee)
        {
            var result = new List<EmployeeViewModel>();
            if (employee != null && ModelState.IsValid)
            {
                await _employeeService.DeleteAsync((Guid)employee.Id);
                result = (await _employeeService.GetAllAsync()).ToList();
            }
            return Json(result.ToDataSourceResult(request, ModelState));
        }

        private async Task PopulateDepartmentsAsync()
        {
            var departments = await _departmentService.GetAllAsync();
            ViewData["Departments"] = departments;
            ViewData["DefaultDepartment"] = departments.First();
        }
    }
}