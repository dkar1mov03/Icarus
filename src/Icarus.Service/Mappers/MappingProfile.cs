using AutoMapper;
using Icarus.Domain.Entities;
using Icarus.Service.DTOs.Assets;
using Icarus.Service.DTOs.Categories;
using Icarus.Service.DTOs.DepartmentCategories;

namespace Icarus.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Assets
        CreateMap<Asset,AssetForResultDto>().ReverseMap();
        CreateMap<Asset,AssetForUpdateDto>().ReverseMap();
        CreateMap<Asset,AssetForCreationDto>().ReverseMap();

        // Categories
        CreateMap<Category,CategoryForResultDto>().ReverseMap();
        CreateMap<Category,CategoryForUpdateDto>().ReverseMap();
        CreateMap<Category,CategoryForCreationDto>().ReverseMap();

        // DepartmentCategories
        CreateMap<DepartmentCategory,DepartmentCategoryForUpdateDto>().ReverseMap();
        CreateMap<DepartmentCategory, DepartmentCategoryForResultDto>().ReverseMap();
        CreateMap<DepartmentCategory, DepartmentCategoryForCreationDto>().ReverseMap();

    }
}
