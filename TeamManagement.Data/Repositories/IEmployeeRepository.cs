using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;

namespace TeamManagement.Data.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<Employee> GetEmployeeByIdAsync(int id);

        Task<List<Employee>> GetAllEmployeesAsync();

        Task<Employee> AddEmployeeAsync(int employeeTypeId, int businessUnitId, string initials, string firstnames, string surname, string email, string cellNumber);
    }
}
