using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TeamManagement.Services.Services;
using TeamManagement.Utilities.Dtos;

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

        [Route("api/[controller]/[action]")]
        [HttpGet]
        public IEnumerable<EmployeeDto> GetGetAllEmployees()
        {
            return _employeeService.GetAllEmployeesAsync().Result;
        }

        [Route("api/[controller]/[action]/{id}")]
        [HttpGet]
        public EmployeeDto GetEmployeeById(int id)
        {
            return _employeeService.GetEmployeeByIdAsync(id).Result;
        }

        [Route("api/[controller]/[action]")]
        [HttpPost]
        public EmployeeDto AddEmployee(EmployeeDto employee)
        {
            return _employeeService.AddEmployeeAsync(employee).Result;
        }

        [Route("api/[controller]/[action]")]
        [HttpPost]
        public EmployeeDto TransferEmployee(int id, int newBusinessUnitId)
        {
            return _employeeService.TransferEmployeeAsync(id, newBusinessUnitId).Result;
        }
    }
}
