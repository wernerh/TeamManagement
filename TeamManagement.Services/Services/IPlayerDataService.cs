using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.Services.Services
{
    public interface IPlayerDataService
    {
        Task<PlayerDataDto> GetPlayerDataByIdAsync(int id);
    }
}
