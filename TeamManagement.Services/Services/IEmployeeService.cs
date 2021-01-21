using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.Services.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetAllEmployeesAsync();
        Task<EmployeeDto> GetEmployeeByIdAsync(int id);
        Task<EmployeeDto> AddEmployeeAsync(EmployeeDto employee);
        Task<EmployeeDto> TransferEmployeeAsync(int id, int newBusinessUnitId);
    }
}
