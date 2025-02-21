using Application.ViewModels.PunishmentViewModels;
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
        partial void AddPunishmentMapperConfigs()
        {
            CreateMap<Punishment,PunishmentViewModels>().ReverseMap();
            CreateMap<Punishment,CreatePunishmentViewModel>().ReverseMap();
            CreateMap<PunishmentViewModels,CreatePunishmentViewModel>().ReverseMap();
        }
    }
}
