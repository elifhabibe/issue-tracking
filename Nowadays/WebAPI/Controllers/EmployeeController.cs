using Business.Services.Abstract;
using Business.Services.Concrete;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        IEmployeeService _employeeService = new EmployeeService();
        [HttpGet("employee")]
        public IActionResult GetEmployee(int id)
        {
            var employee = _employeeService.GetEmployee(id);
            return Ok(employee);
        }
        [HttpGet("employees")]
        public IActionResult GetAllEmployee()
        {
            var employees = _employeeService.GetAll();
            return Ok(employees);
        }
        [HttpPost("add")]
        public IActionResult AddEmployee(Employee employee)
        {
            var result = _employeeService.Add(employee);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var result = _employeeService.Update(employee);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult DeleteEmployee(int id)
        {
            var result = _employeeService.Delete(id);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
