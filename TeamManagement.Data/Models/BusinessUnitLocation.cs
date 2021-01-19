using System;
using System.Collections.Generic;
using System.Text;

namespace TeamManagement.Data.Models
{
    public partial class BusinessUnitLocation
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PhysicalLine1 { get; set; }
        public string PhysicalLine2 { get; set; }
        public string PhysicalTown { get; set; }
        public string PhysicalCode { get; set; }
    }
}
