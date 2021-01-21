using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;
using TeamManagement.Data.Repositories;

namespace TeamManagement.Services.Services
{
    public class BusinessUnitService : IBusinessUnitService
    {
        private readonly IBusinessUnitRepository _businessUnitRepository;

        public BusinessUnitService(IBusinessUnitRepository businessUnitRepository)
        {
            _businessUnitRepository = businessUnitRepository;
        }

        public async Task<List<BusinessUnit>> GetAllBusinessUnitsAsync()
        {
            return await _businessUnitRepository.GetAllBusinessUnitsAsync();
        }

        public async Task<BusinessUnit> GetBusinessUnitByIdAsync(int id)
        {
            return await _businessUnitRepository.GetBusinessUnitByIdAsync(id);
        }

        public async Task<BusinessUnit> AddBusinessUnitsAsync(string name, int businessUnitTypeId, int businessUnitLocationId, int? parentBusinessUnitId = null)
        {
            return await _businessUnitRepository.AddBusinessUnitsAsync(name, businessUnitTypeId, businessUnitLocationId, parentBusinessUnitId);
        }
    }
}
