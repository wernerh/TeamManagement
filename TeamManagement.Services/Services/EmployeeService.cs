using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;
using TeamManagement.Data.Repositories;

namespace TeamManagement.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _employeeRepository.GetAllEmployeesAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task<Employee> AddEmployeeAsync(int employeeTypeId, int businessUnitId, string initials, string firstnames, string surname, string email, string cellNumber)
        {
            return await _employeeRepository.AddEmployeeAsync(employeeTypeId, businessUnitId, initials, firstnames, surname, email, cellNumber);
        }
    }
}
