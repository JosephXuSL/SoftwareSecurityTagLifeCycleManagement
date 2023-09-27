using AutoMapper;
using SSTLifeCycleManagement.Entities;
using SSTLifeCycleManagement.Models;
using System.Security.Claims;

namespace SSTLifeCycleManagement.DbContexts
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AdminDto, Admin>().ReverseMap();
            CreateMap<AdminAccountDto, AdminAccount>().ReverseMap();
            CreateMap<DeveloperDto, Developer>().ReverseMap();
            CreateMap<RoleAccessDto, Admin>().ReverseMap();
            CreateMap<SecurityTagDto, SecurityTag>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserAccountDto, UserAccount>().ReverseMap();
            CreateMap<UserRoleDto, UserRole>().ReverseMap();
        }
    }
}
