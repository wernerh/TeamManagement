using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;

namespace TeamManagement.Data.Repositories
{
    public interface IBusinessUnitRepository : IRepository<BusinessUnit>
    {
        Task<BusinessUnit> GetBusinessUnitByIdAsync(int id);

        Task<List<BusinessUnit>> GetAllBusinessUnitsAsync();

        Task<BusinessUnit> AddBusinessUnitsAsync(string name, int businessUnitTypeId, int businessUnitLocationId, int? parentBusinessUnitId = null);

        Task<BusinessUnit> UpdateBusinessUnitLocationAsync(int id, int newBusinessUnitLocationId);
    }
}
