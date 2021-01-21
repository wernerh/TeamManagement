using AutoMapper;
using TeamManagement.Data.Models;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.Services.Profiles
{
    class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeType, EmployeeTypeDto>();
        }
    }
}
