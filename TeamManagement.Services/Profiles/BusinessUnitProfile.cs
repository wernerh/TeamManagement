using AutoMapper;
using TeamManagement.Data.Models;
using TeamManagement.Utilities.Dtos;


namespace TeamManagement.Services.Profiles
{
    public class BusinessUnitProfile : Profile
    {
        public BusinessUnitProfile()
        {
            CreateMap<BusinessUnit, BusinessUnitDto>();
            CreateMap<BusinessUnitType, BusinessUnitTypeDto>();
            CreateMap<BusinessUnitLocation, BusinessUnitLocationDto>();
        }
    }
}
