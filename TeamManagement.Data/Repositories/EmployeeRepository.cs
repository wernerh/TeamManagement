using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;

namespace TeamManagement.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(TeamManagementContext teamManagementContext) : base(teamManagementContext)
        {
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<Employee> AddEmployeeAsync(int employeeTypeId, int businessUnitId, string initials, string firstnames, string surname, string email, string cellNumber)
        {
            return await AddAsync(new Employee { EmployeeTypeId = employeeTypeId,
                                                 BusinessUnitId = businessUnitId,
                                                 Initials = initials,
                                                 Firstnames = firstnames,
                                                 Surname = surname,
                                                 Email = email,
                                                 CellNumber = cellNumber
            });
        }
    }
}
