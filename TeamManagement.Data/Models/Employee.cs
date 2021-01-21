using System;
using System.Collections.Generic;
using System.Text;

namespace TeamManagement.Data.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public int EmployeeTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public string Initials { get; set; }
        public string Firstnames { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string CellNumber { get; set; }

        public BusinessUnit BusinessUnit { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
