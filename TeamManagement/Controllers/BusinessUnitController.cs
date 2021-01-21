using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using TeamManagement.Services.Services;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.Controllers
{
    [ApiController]
    public class BusinessUnitController : ControllerBase
    {
        private readonly ILogger<BusinessUnitController> _logger;
        private readonly IBusinessUnitService _businessUnitService;

        public BusinessUnitController(ILogger<BusinessUnitController> logger, IBusinessUnitService businessUnitService)
        {
            _logger = logger;
            _businessUnitService = businessUnitService;
        }

        [Route("api/[controller]/[action]")]
        [HttpGet]
        public IEnumerable<BusinessUnitDto> GetAllBusinessUnits()
        {
            return _businessUnitService.GetAllBusinessUnitsAsync().Result.ToList();
        }


        [Route("api/[controller]/[action]/{id}")]
        [HttpGet]
        public BusinessUnitDto GetBusinessUnitById(int id)
        {
            return _businessUnitService.GetBusinessUnitByIdAsync(id).Result;
        }


        [Route("api/[controller]/[action]")]
        [HttpPost]
        public BusinessUnitDto AddBusinessUnit(BusinessUnitDto unit)
        {
            return _businessUnitService.AddBusinessUnitsAsync(unit).Result;
        }
    }
}
