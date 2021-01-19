using System;
using System.Collections.Generic;
using System.Text;

namespace TeamManagement.Data.Models
{
    public partial class BusinessUnit
    {
        public int Id { get; set; }
        public int ParentBusinessUnitId { get; set; }
        public int BusinessUnitTypeId { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
    }
}
