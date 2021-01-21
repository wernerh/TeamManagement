using TeamManagement.Utilities.Enums;

namespace TeamManagement.Utilities.Dtos
{
    public class BusinessUnitDto
    {
        public int? ParentBusinessUnitId { get; set; }
        public int BusinessUnitTypeId { get; set; }
        public int BusinessUnitLocationId { get; set; }
        public string Name { get; set; }

        public BusinessUnitTypeEnum BusinessUnitType { get; set; }
    }
}
