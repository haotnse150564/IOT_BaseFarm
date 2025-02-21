using Application.ViewModels;
using Application.ViewModels.ImportViewModel;
using Application.ViewModels.inventoryviewmodels;
using Application.ViewModels.InventoryViewModels;
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
        partial void AddInventoryMapperConfig()
        {
            CreateMap<Inventory, InventoryViewModel>()
                .ForMember(des => des.CategoryId, src => src.MapFrom(x => x.InventoryCategories.Name.ToString()))
                .ReverseMap();
            CreateMap<Inventory, CreateInventoryViewModel>()
                .ReverseMap();
            CreateMap<Inventory, UpdateImportViewModel>().ReverseMap();
            CreateMap<InventoryCategory, InventoryCategoryViewModels>().ReverseMap();

        }
    }
}
