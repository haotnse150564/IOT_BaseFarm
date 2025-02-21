using Application.ViewModels.ImportViewModel;
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
        partial void AddImportMapperConfigs()
        {
            CreateMap<Import, ImportViewModel>()
                .ReverseMap();
            CreateMap<Import, CreateImportViewModel>().ReverseMap();
            CreateMap<Import, UpdateImportViewModel>().ReverseMap();
        }
    }
}
