using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;

namespace TeamManagement.Services.Services
{
    public interface IBusinessUnitService
    {
        Task<List<BusinessUnit>> GetAllBusinessUnitsAsync();
        Task<BusinessUnit> GetCustomerByIdAsync(int id);     
    }
}
