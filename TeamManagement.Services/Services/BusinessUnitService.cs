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

        public async Task<BusinessUnit> GetCustomerByIdAsync(int id)
        {
            return await _businessUnitRepository.GetBusinessUnitByIdAsync(id);
        }
    }
}
