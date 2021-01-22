using System;
using System.Collections.Generic;
using System.Text;

namespace TeamManagement.Utilities.Dtos
{
    public class PlayerDataDto
    {
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public int EmployeeId { get; set; }
        public EmployeeDto Employee { get; set; }
    }
}
