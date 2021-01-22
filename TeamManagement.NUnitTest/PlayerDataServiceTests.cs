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
    public class PlayerDataServiceTests
    {
        private PlayerDataService _playerDataService;
        private Mock<IPlayerDataRepository> _mockRepository;
        private IMapper _mockMapper;

        [SetUp]
        public void Setup()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(new PlayerDataProfile()));
            _mockMapper = new Mapper(configuration);
            _mockRepository = new Mock<IPlayerDataRepository>();
            _playerDataService = new PlayerDataService(_mockRepository.Object, _mockMapper);
        }
        [Test]
        public void GetPlayerDataById()
        {
            var EmployeeId = 1;
            var playerData = new PlayerData
            {
                Id = 1,
                EmployeeId = 2,
                Weight = 96,
                Height = 1.88,
                Age = 26
            };

            var playerDataDto = new PlayerDataDto
            {
                EmployeeId = 2,
                Weight = 96,
                Height = 1.88,
                Age = 26
            };

            _mockRepository.Setup(x => x.GetPlayerDataByIdAsync(EmployeeId))
                           .ReturnsAsync(playerData);

            var resultDto = _playerDataService.GetPlayerDataByIdAsync(EmployeeId).Result;

            Assert.AreEqual(resultDto.EmployeeId, playerData.EmployeeId);
            Assert.AreEqual(resultDto.Weight, playerData.Weight);
            Assert.AreEqual(resultDto.Height, playerData.Height);
        }
    }
}