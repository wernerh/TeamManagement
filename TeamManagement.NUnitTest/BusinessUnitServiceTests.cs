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
    public class BusinessUnitServiceTests
    {
        private BusinessUnitService _businessUnitService;
        private Mock<IBusinessUnitRepository> _mockRepository;
        private IMapper _mockMapper;

        [SetUp]
        public void Setup()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(new BusinessUnitProfile()));
            _mockMapper = new Mapper(configuration);
            _mockRepository = new Mock<IBusinessUnitRepository>();
            _businessUnitService = new BusinessUnitService(_mockRepository.Object, _mockMapper);
        }
        [Test]
        public void GetBusinessUnitById()
        {
            var businessUnitId = 1;
            var businessUnit = new BusinessUnit
            {
                Id = 1,
                BusinessUnitTypeId = 1,
                BusinessUnitLocationId = 1,
                Name = "Blue Bulls"
            };

            _mockRepository.Setup(x => x.GetBusinessUnitByIdAsync(businessUnitId))
                           .ReturnsAsync(businessUnit);

            var businessUnitDto = _businessUnitService.GetBusinessUnitByIdAsync(businessUnitId).Result;

            Assert.AreEqual(businessUnitDto.BusinessUnitTypeId, businessUnit.BusinessUnitTypeId);
            Assert.AreEqual(businessUnitDto.BusinessUnitLocationId, businessUnit.BusinessUnitLocationId);
            Assert.AreEqual(businessUnitDto.Name, businessUnitDto.Name);
        }


        [Test]
        public void AddBusinessUnit()
        {
            var businessUnit = new BusinessUnit
            {
                Id = 1,
                BusinessUnitTypeId = 1,
                BusinessUnitLocationId = 1,
                Name = "Blue Bulls"
            };

            var businessUnitDto = new BusinessUnitDto
            {
                BusinessUnitTypeId = 1,
                BusinessUnitLocationId = 1,
                Name = "Blue Bulls"
            };

            _mockRepository.Setup(x => x.AddBusinessUnitsAsync(businessUnitDto.Name, businessUnitDto.BusinessUnitTypeId, businessUnitDto.BusinessUnitLocationId, businessUnitDto.ParentBusinessUnitId))
                           .ReturnsAsync(businessUnit);

            var resultDto = _businessUnitService.AddBusinessUnitsAsync(businessUnitDto).Result;

            Assert.AreEqual(resultDto.Name, businessUnitDto.Name);
        }

    }
}