using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagementSystem.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController( IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var response = await _employeeService.GetAllAsync();
            return Ok(response);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(Guid id)
        {
            var response = await _employeeService.GetAsync(id);
            return Ok(response);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] EmployeeViewModel employee)
        {
            var response = await _employeeService.SaveAsync(employee);
            return Ok(response);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut]
        public async Task<ActionResult> PutAsync( [FromBody] EmployeeViewModel employee)
        {
            var response = await _employeeService.UpdateAsync(employee);
            return Ok(response);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            var response = await _employeeService.DeleteAsync(id);
            return Ok( response);
        }
    }
}
