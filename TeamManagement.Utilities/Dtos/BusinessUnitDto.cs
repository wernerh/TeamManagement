

namespace TeamManagement.Utilities.Dtos
{
    public class BusinessUnitDto
    {
        public int? ParentBusinessUnitId { get; set; }
        public int BusinessUnitTypeId { get; set; }
        public int BusinessUnitLocationId { get; set; }
        public string Name { get; set; }

        public BusinessUnitTypeDto BusinessUnitType { get; set; }

        public BusinessUnitLocationDto BusinessUnitLocation { get; set; }
    }
}
