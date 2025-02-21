using Application.ViewModels.WorkSheetViewModels;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappers
{
    public partial class MapperConfigs : Profile
    {
        partial void AddWorkSheetMapperConfig()
        {
            CreateMap<WorkSheet,WorkSheetViewModel>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToString("dd-MM-yyyy")))
                .ForMember(dest => dest.Shift, opt => opt.MapFrom(src => src.Shift.ToString()))
                .ForMember(dest => dest.listUser, opt => opt.MapFrom(src => src.UserWorkSheet))
                .ReverseMap()
                ;

            CreateMap<WorkSheet,AddWorkSheetViewModel>().ReverseMap();
        }
    }
}
