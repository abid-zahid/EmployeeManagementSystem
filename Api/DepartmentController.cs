using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagementSystem.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        // GET: api/<DepartmentController>
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var reponse = await _departmentService.GetAllAsync();
            return Ok(reponse);
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(Guid id)
        {
            var response = await _departmentService.GetAsync(id);
            return Ok(response);
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] DepartmentViewModel department)
        {
            var response = await _departmentService.SaveAsync(department);
            return Ok(response);
        }

        // PUT api/<DepartmentController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] DepartmentViewModel department)
        {
            var response = await _departmentService.UpdateAsync(department);
            return Ok(response);
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            var response = await _departmentService.DeleteAsync(id);
            return Ok(response);
        }
    }
}