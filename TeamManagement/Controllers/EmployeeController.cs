using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using TeamManagement.Data.Models;
using TeamManagement.Services.Services;

namespace TeamManagement.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [Route("api/Employee/GetAllEmployees")]
        [HttpGet]
        public IEnumerable<Employee> GetGetAllEmployees()
        {
            return _employeeService.GetAllEmployeesAsync().Result;
        }

        [Route("api/Employee/GetEmployeeById/{id}")]
        [HttpGet]
        public Employee GetEmployeeById(int id)
        {
            return _employeeService.GetEmployeeByIdAsync(id).Result;
        }
    }
}
