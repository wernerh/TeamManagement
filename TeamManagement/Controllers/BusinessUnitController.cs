using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using TeamManagement.Data.Models;
using TeamManagement.Services.Services;

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


        [Route("api/BusinessUnit/GetAllBusinessUnits")]
        [HttpGet]
        public IEnumerable<BusinessUnit> GetAllBusinessUnits()
        {
            return _businessUnitService.GetAllBusinessUnitsAsync().Result.ToList();
        }


        [Route("api/BusinessUnit/GetBusinessUnitById/{id}")]
        [HttpGet]
        public BusinessUnit GetBusinessUnitById(int id)
        {
            return _businessUnitService.GetBusinessUnitByIdAsync(id).Result;
        }


        [Route("api/BusinessUnit/AddBusinessUnit")]
        [HttpPost]
        public BusinessUnit AddBusinessUnit(BusinessUnit unit)
        {
            return _businessUnitService.AddBusinessUnitsAsync(unit.Name, unit.BusinessUnitTypeId, unit.BusinessUnitLocationId, unit.ParentBusinessUnitId).Result;
        }
    }
}
