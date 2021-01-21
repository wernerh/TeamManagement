﻿using AutoMapper;
using TeamManagement.Data.Models;
using TeamManagement.Utilities.Dtos;

namespace TeamManagement.Services.Profiles
{
    class BusinessUnitProfile : Profile
    {
        public BusinessUnitProfile()
        {
            CreateMap<BusinessUnit, BusinessUnitDto>();
        }
    }
}
