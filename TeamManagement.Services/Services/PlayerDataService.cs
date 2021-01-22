using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;
using TeamManagement.Data.Repositories;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.Services.Services
{
    public class PlayerDataService : IPlayerDataService
    {
        private readonly IPlayerDataRepository _playerDataRepository;
        private readonly IMapper _mapper;

        public PlayerDataService(IPlayerDataRepository playerDataRepository, IMapper mapper)
        {
            _playerDataRepository = playerDataRepository;
            _mapper = mapper;
        }

        public async Task<PlayerDataDto> GetPlayerDataByIdAsync(int id)
        {
            var result = await _playerDataRepository.GetPlayerDataByIdAsync(id);
            return _mapper.Map<PlayerDataDto>(result);
        }
    }
}
