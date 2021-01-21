using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.Services.Services
{
    public interface IBusinessUnitService
    {
        Task<List<BusinessUnitDto>> GetAllBusinessUnitsAsync();
        Task<BusinessUnitDto> GetBusinessUnitByIdAsync(int id);
        Task<BusinessUnitDto> AddBusinessUnitsAsync(BusinessUnitDto unit);
    }
}
