using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TeamManagement.Services.Services;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.Controllers
{
    [ApiController]
    public class PlayerDataController : ControllerBase
    {

        private readonly ILogger<PlayerDataController> _logger;
        private readonly IPlayerDataService _playerDataService;

        public PlayerDataController(ILogger<PlayerDataController> logger, IPlayerDataService playerDataService)
        {
            _logger = logger;
            _playerDataService = playerDataService;
        }

        [Route("api/[controller]/[action]/{id}")]
        [HttpGet]
        public PlayerDataDto GetPlayerDataById(int id)
        {
            return _playerDataService.GetPlayerDataByIdAsync(id).Result;
        }
    }
}
