

namespace TeamManagement.Utilities.Dtos
{
    public class EmployeeDto
    {
        public int BusinessUnitId { get; set; }
        public int EmployeeTypeId { get; set; }
        public string Initials { get; set; }
        public string Firstnames { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string CellNumber { get; set; }

        public EmployeeTypeDto EmployeeType { get; set; }
    }
}
