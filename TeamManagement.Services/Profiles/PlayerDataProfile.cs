using AutoMapper;
using TeamManagement.Data.Models;
using TeamManagement.Utilities.Dtos;


namespace TeamManagement.Services.Profiles
{
    public class PlayerDataProfile : Profile
    {
        public PlayerDataProfile()
        {
            CreateMap<PlayerData, PlayerDataDto>();
        }
    }
}
