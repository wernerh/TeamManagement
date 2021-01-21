using System;
using System.Collections.Generic;
using System.Text;

namespace TeamManagement.Data.Models
{
    public partial class PlayerData
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
