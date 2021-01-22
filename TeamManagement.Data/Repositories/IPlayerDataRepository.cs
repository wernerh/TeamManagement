using System.Threading.Tasks;
using TeamManagement.Data.Models;

namespace TeamManagement.Data.Repositories
{
    public interface IPlayerDataRepository : IRepository<PlayerData>
    {
        Task<PlayerData> GetPlayerDataByIdAsync(int id);
    }
}
