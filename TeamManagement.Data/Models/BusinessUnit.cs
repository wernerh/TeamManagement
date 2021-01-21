using System;
using System.Collections.Generic;
using System.Text;

namespace TeamManagement.Data.Models
{
    public partial class BusinessUnit
    {
        public int Id { get; set; }
        public int? ParentBusinessUnitId { get; set; }
        public int BusinessUnitTypeId { get; set; }
        public int BusinessUnitLocationId { get; set; }
        public string Name { get; set; }


        public BusinessUnitLocation BusinessUnitLocation { get; set; }
        public BusinessUnitType BusinessUnitType { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
