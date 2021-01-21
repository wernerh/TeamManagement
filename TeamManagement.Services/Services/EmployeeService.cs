using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;
using TeamManagement.Data.Repositories;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDto>> GetAllEmployeesAsync()
        {
            var result = await _employeeRepository.GetAllEmployeesAsync();
            return _mapper.Map<List<Employee>, List<EmployeeDto>>(result);
        }

        public async Task<EmployeeDto> GetEmployeeByIdAsync(int id)
        {
            var result = await _employeeRepository.GetEmployeeByIdAsync(id);
            return _mapper.Map<EmployeeDto>(result);
        }

        public async Task<EmployeeDto> AddEmployeeAsync(EmployeeDto employee)
        {
            var result = await _employeeRepository
                                .AddEmployeeAsync(employee.EmployeeTypeId, employee.BusinessUnitId, employee.Initials,
                                                  employee.Firstnames, employee.Surname, employee.Email, employee.CellNumber);

            return _mapper.Map<EmployeeDto>(result);
        }

        public async Task<EmployeeDto> TransferEmployeeAsync(int id, int newBusinessUnitId)
        {
            var result = await _employeeRepository.TransferEmployeeAsync(id, newBusinessUnitId);
            return _mapper.Map<EmployeeDto>(result);
        }
    }
}
