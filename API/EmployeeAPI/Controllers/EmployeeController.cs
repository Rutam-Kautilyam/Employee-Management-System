using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class EmployeeController: ControllerBase
    {
        private static readonly List<Employee> employees = new()
        {
            new Employee { Id = 1, Name = "Rahul", Salary = 30000 },
            new Employee { Id = 2, Name = "Priya", Salary = 40000 }
        };

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null) return NotFound();

            return Ok(employee);
        }
    }
}
