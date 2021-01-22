using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TeamManagement.Data.Models;

namespace TeamManagement.Data.Repositories
{
    public class PlayerDataRepository : Repository<PlayerData>, IPlayerDataRepository
    {
        public PlayerDataRepository(TeamManagementContext teamManagementContext) : base(teamManagementContext)
        {
        }

        public async Task<PlayerData> GetPlayerDataByIdAsync(int id)
        {
            return await GetAll()
                            .Include(x => x.Employee)
                            .Include(x => x.Employee.EmployeeType)
                            .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
