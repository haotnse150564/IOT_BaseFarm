using Application.ViewModels.UserWorkSheetViewModels;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappers
{
    public partial class MapperConfigs : Profile
    {
        partial void AddUserWorkSheetMapperConfig()
        {
            CreateMap<UserWorkSheet, UserWorkSheetViewModel>()
                .ReverseMap();
        }
    }
}
