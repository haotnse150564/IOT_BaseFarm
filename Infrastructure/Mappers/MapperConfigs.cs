using Application.Commons;
using AutoMapper;


namespace Infrastructure.Mappers
{
    public partial class MapperConfigs : Profile
    {
        public MapperConfigs()
        {
            //add map here
            //CreateMap<SourceModel, DestinationModel>();

            // Create mapping between Pagination
            CreateMap(typeof(Pagination<>), typeof(Pagination<>));

            AddUserMapperConfig();

            AddInventoryMapperConfig();

            AddInvoiceMapperConfig();

            AddInvoiceDetailsMapperConfig();

            AddProductMapperConfig();

            AddUserMapperConfig();

            AddWorkSheetMapperConfig();

            AddRequesttMapperConfig();

            AddImportMapperConfigs();

            AddImportDetailsMapperConfigs();

            AddVoucherMapperConfigs();

            AddPunishmentMapperConfigs();

            AddUserWorkSheetMapperConfig();

            AddDamagesAssetMapperConfigs();

            AddOverTimeWorkSheetMapperConfigs();
            AddProductCategoryMapperConfig();
        }
        
        partial void AddUserMapperConfig();
        partial void AddInventoryMapperConfig();
        partial void AddInvoiceMapperConfig();
        partial void AddInvoiceDetailsMapperConfig();
        partial void AddProductMapperConfig();
        partial void AddWorkSheetMapperConfig();
        partial void AddRequesttMapperConfig();
        partial void AddImportMapperConfigs();
        partial void AddPunishmentMapperConfigs();
        partial void AddImportDetailsMapperConfigs();
        partial void AddUserWorkSheetMapperConfig();
        partial void AddVoucherMapperConfigs();
        partial void AddDamagesAssetMapperConfigs();
        partial void AddOverTimeWorkSheetMapperConfigs();
        partial void AddProductCategoryMapperConfig();
    }
}

