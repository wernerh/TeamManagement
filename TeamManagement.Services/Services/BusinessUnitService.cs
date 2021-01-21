using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamManagement.Data.Models;
using TeamManagement.Data.Repositories;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.Services.Services
{
    public class BusinessUnitService : IBusinessUnitService
    {
        private readonly IBusinessUnitRepository _businessUnitRepository;
        private readonly IMapper _mapper;

        public BusinessUnitService(IBusinessUnitRepository businessUnitRepository, IMapper mapper)
        {
            _businessUnitRepository = businessUnitRepository;
            _mapper = mapper;
        }

        public async Task<List<BusinessUnitDto>> GetAllBusinessUnitsAsync()
        {
            var result = await _businessUnitRepository.GetAllBusinessUnitsAsync();
            return _mapper.Map<List<BusinessUnit>, List<BusinessUnitDto>>(result);
        }

        public async Task<BusinessUnitDto> GetBusinessUnitByIdAsync(int id)
        {
            var result = await _businessUnitRepository.GetBusinessUnitByIdAsync(id);
            return _mapper.Map<BusinessUnitDto>(result);
        }

        public async Task<BusinessUnitDto> AddBusinessUnitsAsync(BusinessUnitDto unit)
        {
            var result = await _businessUnitRepository
                                .AddBusinessUnitsAsync(unit.Name, unit.BusinessUnitTypeId,
                                                       unit.BusinessUnitLocationId, unit.ParentBusinessUnitId);

            return _mapper.Map<BusinessUnitDto>(result);
        }
    }
}
