using Application.ViewModels.UserViewModels;
using AutoMapper;
using Domain.Enums;
using Domain.Models;
using Microsoft.OpenApi.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappers
{
    public partial class MapperConfigs : Profile
    {
        partial void AddUserMapperConfig()
        {
            /*createmap<users, userdetailmodel>()
                .formember(des => des.role, act => act.mapfrom(src => enum.getname(typeof(role), src.role)))
                .formember(des => des.gender, act => act.mapfrom(src => (src.gender == false) ? "female" : "male"))
                .formember(des => des.status, act => act.mapfrom(src => (src.isactive == true) ? "active" : "inactive"));*/

            CreateMap<Users, UserDetailModel>()
                .ForMember(des => des.Role, act => act.MapFrom(src => Enum.GetName(typeof(Role), src.Role)))
                .ForMember(des => des.Gender, act => act.MapFrom(src => (src.Gender == false) ? "Female" : "Male"))
                .ForMember(des => des.Status, act => act.MapFrom(src => (src.isActive == true) ? "Active" : "Inactive"))
                .ForMember(des => des.CreateDate, act => act.MapFrom(src => src.CreateDate.ToString("dd/MM/yyyy")))
                .ForMember(des => des.DateOfBirth, act => act.MapFrom(src => src.DateOfBirth.ToString("dd/MM/yyyy")))
                .ForMember(des => des.ContractExpiration, act => act.MapFrom(src => src.ContractExpiration.ToString("dd/MM/yyyy")))
                .ForMember(des => des.StartToWork, act => act.MapFrom(src => src.StartToWork.ToString("dd/MM/yyyy")));

            CreateMap<Users, UserLoginModel>().ReverseMap();
                
            CreateMap<UserCreateModel, Users>().ReverseMap();

            CreateMap<UpdateUserModels, Users>().ReverseMap();

        }

    }
}
