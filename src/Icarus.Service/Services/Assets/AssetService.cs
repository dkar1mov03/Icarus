using AutoMapper;
using Icarus.Data.IRepositories.Assets;
using Icarus.Domain.Entities;
using Icarus.Service.DTOs.Assets;
using Icarus.Service.Exceptions;
using Icarus.Service.Interfaces.Assets;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Service.Services.Assets;

public class AssetService : IAssetService
{
    private readonly IMapper _mapper;
    private readonly IAssetRepository _assetRepository;

    public AssetService(IMapper mapper, IAssetRepository assetRepository)
    {
        _mapper = mapper;
        _assetRepository = assetRepository;
    }

    public async Task<AssetForResultDto> CreateAsync(AssetForCreationDto dto)
    {
        var asset = await _assetRepository.SelectAll()
            .Where(a => a.Email.ToLower() == dto.Email.ToLower()
            && a.Phone == dto.Phone)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (asset is not null)
            throw new IcarusException(409, "Asset is already exists");

        var mappedAsset = _mapper.Map<Asset>(dto);
        mappedAsset.CreatedAt = DateTime.UtcNow;
        var createAsset = await _assetRepository.InsertAsync(mappedAsset);

        return _mapper.Map<AssetForResultDto>(createAsset);
    }

    public async Task<AssetForResultDto> ModifyAsync(long id, AssetForUpdateDto dto)
    {
        var asset = await _assetRepository.SelectAll()
            .Where(a => a.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (asset is null)
            throw new IcarusException(404, "Asset is not found");

        var mappedAsset = _mapper.Map(dto, asset);
        mappedAsset.UpdatedAt = DateTime.UtcNow;

        await _assetRepository.UpdateAsync(mappedAsset);

        return _mapper.Map<AssetForResultDto>(mappedAsset);
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AssetForResultDto>> RetrieveAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<AssetForResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }
}
