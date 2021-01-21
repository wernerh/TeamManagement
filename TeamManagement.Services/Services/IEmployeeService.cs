using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;

namespace TeamManagement.Services.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> AddEmployeeAsync(int employeeTypeId, int businessUnitId, string initials, string firstnames, string surname, string email, string cellNumber);
    }
}
