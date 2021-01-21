using AutoMapper;
using Moq;
using NUnit.Framework;
using TeamManagement.Data.Repositories;
using TeamManagement.Services.Services;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.NUnitTest
{
    public class EmployeeServiceTests
    {
        private EmployeeService _employeeService;

        [SetUp]
        public void Setup()
        {
            var mockRepository = new Mock<IEmployeeRepository>();
            var mockMapper = new Mock<IMapper>();

            _employeeService = new EmployeeService(mockRepository.Object, mockMapper.Object);
        }

        [Test]
        public void AddEmployee()
        {
           var test = _employeeService.AddEmployeeAsync(new EmployeeDto
            {
                Initials = "hp",
                Firstnames = "Handrè",
                Surname = "Pollard",
                Email = "test@gmail.com",
                CellNumber = "1234567890",
                EmployeeTypeId = 5,
                BusinessUnitId = 2
            });

            Assert.Pass();
        }
    }
}