using AutoMapper;
using Icarus.Domain.Entities;
using Icarus.Service.DTOs.Assets;

namespace Icarus.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Assets
        CreateMap<Asset,AssetForResultDto>().ReverseMap();
        CreateMap<Asset,AssetForUpdateDto>().ReverseMap();
        CreateMap<Asset,AssetForCreationDto>().ReverseMap();
    }
}
