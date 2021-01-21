using TeamManagement.Utilities.Enums;

namespace TeamManagement.Utilities.Dtos
{
    public class EmployeeDto
    {
        public int BusinessUnitId { get; set; }
        public string Initials { get; set; }
        public string Firstnames { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string CellNumber { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
    }
}
