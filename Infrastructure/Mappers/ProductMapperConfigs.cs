using Application.ViewModels.ProductViewModels;
using Application.ViewModels.VoucherViewModels;
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
        partial void AddProductMapperConfig()
        {
            CreateMap<Product, AddProductViewModel>().ReverseMap();

            CreateMap<ProductViewModel, Product>().ReverseMap()
                .ForMember(dest => dest.CategoryName, opt => opt.Ignore())
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
                .ReverseMap();

        }
    }
}
