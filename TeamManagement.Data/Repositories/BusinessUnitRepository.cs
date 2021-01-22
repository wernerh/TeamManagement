using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;

namespace TeamManagement.Data.Repositories
{
    public class BusinessUnitRepository : Repository<BusinessUnit>, IBusinessUnitRepository
    {
        public BusinessUnitRepository(TeamManagementContext teamManagementContext) : base(teamManagementContext)
        {
        }

        public async Task<BusinessUnit> GetBusinessUnitByIdAsync(int id)
        {
            return await GetAll()
                            .Include(x => x.BusinessUnitLocation)
                            .Include(x => x.BusinessUnitType)
                            .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<BusinessUnit>> GetAllBusinessUnitsAsync()
        {
            return await GetAll()
                            .Include(x => x.BusinessUnitLocation)
                            .Include(x => x.BusinessUnitType)
                            .ToListAsync();
        }

        public async Task<BusinessUnit> AddBusinessUnitsAsync(string name, int businessUnitTypeId, int businessUnitLocationId, int? parentBusinessUnitId = null)
        {
            return await AddAsync(new BusinessUnit { Name = name, BusinessUnitTypeId = businessUnitTypeId, BusinessUnitLocationId = businessUnitLocationId, ParentBusinessUnitId = parentBusinessUnitId });
        }

        public async Task<BusinessUnit> UpdateBusinessUnitLocationAsync(int id, int newBusinessUnitLocationId)
        {
            var businessUnit = GetAll().FirstOrDefaultAsync(x => x.Id == id).Result;
            businessUnit.BusinessUnitLocationId = newBusinessUnitLocationId;

            return await UpdateAsync(businessUnit);
        }
    }
}
