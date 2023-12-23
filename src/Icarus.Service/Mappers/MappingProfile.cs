using AutoMapper;
using Icarus.Domain.Entities;
using Icarus.Service.DTOs.Assets;
using Icarus.Service.DTOs.Categories;
<<<<<<< HEAD
using Icarus.Service.DTOs.DepartmentCategories;
=======
using Icarus.Service.DTOs.Users;
>>>>>>> f402d2ca69fb4d62a1a466115dfe5b9cd77079f6

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

        // Users
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();

    }
}
