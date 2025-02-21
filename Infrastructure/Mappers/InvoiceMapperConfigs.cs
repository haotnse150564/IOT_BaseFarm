using Application.ViewModels.InvoiceViewModels;
using AutoMapper;
using Domain.Enums;
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
        partial void AddInvoiceMapperConfig()
        {
            CreateMap<Invoice,AddInvoiceViewModel>().ReverseMap();
            CreateMap<Invoice,InvoiceViewModel>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToString("dd-MM-yyyy")))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Enum.GetName(typeof(Status), src.Status)))
                .ForMember(dest => dest.Username,opt=>opt.MapFrom(x => x.Users.FullName.ToString()))
                .ReverseMap();
        }
    }
}
