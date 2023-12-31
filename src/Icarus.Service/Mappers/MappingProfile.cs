﻿using AutoMapper;
using Icarus.Domain.Entities;
using Icarus.Service.DTOs.Assets;
using Icarus.Service.DTOs.Categories;

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
        CreateMap<Category,CategoryForCreationDto>().ReverseMap();
        CreateMap<Category,CategoryForResultDto>().ReverseMap();
        CreateMap<Category,CategoryForUpdateDto>().ReverseMap();

    }
}
