using Application.ViewModels.DamagesAsset;
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
        partial void AddDamagesAssetMapperConfigs()
        {
            CreateMap<DamagesAsset, DamageAssetViewModel>().ReverseMap();
            CreateMap<DamagesAsset, CreateDamageAssetViewModels>().ReverseMap();
            CreateMap<DamagesAsset, UpdateDamageAssetViewModel>().ReverseMap();
        }
    }
}
