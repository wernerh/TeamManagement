using AutoMapper;
using Moq;
using NUnit.Framework;
using TeamManagement.Data.Models;
using TeamManagement.Data.Repositories;
using TeamManagement.Services.Profiles;
using TeamManagement.Services.Services;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.NUnitTest
{
    public class EmployeeServiceTests
    {
        private EmployeeService _employeeService;
        private Mock<IEmployeeRepository> _mockRepository;
        private IMapper _mockMapper;

        [SetUp]
        public void Setup()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(new EmployeeProfile()));
            _mockMapper = new Mapper(configuration);
            _mockRepository = new Mock<IEmployeeRepository>();
            _employeeService = new EmployeeService(_mockRepository.Object, _mockMapper);
        }

        [Test]
        public void GetEmployeeById()
        {
            var employeeId = 1;
            var employee = new Employee
            {
                Id = 1,
                Initials = "hp",
                Firstnames = "Handrè",
                Surname = "Pollard",
                Email = "test@gmail.com",
                CellNumber = "1234567890",
                EmployeeTypeId = 5,
                BusinessUnitId = 2
            };

            _mockRepository.Setup(x => x.GetEmployeeByIdAsync(employeeId))
                           .ReturnsAsync(employee);

            var employeeDto = _employeeService.GetEmployeeByIdAsync(employeeId).Result;

            Assert.AreEqual(employeeDto.Firstnames, employee.Firstnames);
            Assert.AreEqual(employeeDto.Surname, employee.Surname);
            Assert.AreEqual(employeeDto.Email, employee.Email);
        }


        [Test]
        public void AddEmployee()
        {
            var employee = new Employee
            {
                Id = 1,
                Initials = "hp",
                Firstnames = "Handrè",
                Surname = "Pollard",
                Email = "test@gmail.com",
                CellNumber = "1234567890",
                EmployeeTypeId = 5,
                BusinessUnitId = 2
            };

            var employeeDto = new EmployeeDto
            {
                Initials = "hp",
                Firstnames = "Handrè",
                Surname = "Pollard",
                Email = "test@gmail.com",
                CellNumber = "1234567890",
                EmployeeTypeId = 5,
                BusinessUnitId = 2
            };

            _mockRepository.Setup(x => x.AddEmployeeAsync(employee.EmployeeTypeId, employee.BusinessUnitId, employee.Initials, employee.Firstnames, employee.Surname, employee.Email, employee.CellNumber))
                           .ReturnsAsync(employee);

            var resultDto = _employeeService.AddEmployeeAsync(employeeDto).Result;

            Assert.AreEqual(resultDto.Firstnames, employeeDto.Firstnames);
        }


        [Test]
        public void TransferEmployee()
        {
            var employeeId = 1;
            var businessUnitId = 5;
            var employee = new Employee
            {
                Id = employeeId,
                Initials = "hp",
                Firstnames = "Handrè",
                Surname = "Pollard",
                Email = "test@gmail.com",
                CellNumber = "1234567890",
                EmployeeTypeId = 5,
                BusinessUnitId = businessUnitId
            };

            _mockRepository.Setup(x => x.TransferEmployeeAsync(employeeId, businessUnitId))
                           .ReturnsAsync(employee);

            var employeeDto = _employeeService.TransferEmployeeAsync(employeeId, businessUnitId).Result;

            Assert.AreEqual(employeeDto.BusinessUnitId, employee.BusinessUnitId);
        }
    }
}