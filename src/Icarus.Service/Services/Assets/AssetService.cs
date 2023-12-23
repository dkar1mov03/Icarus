using AutoMapper;
using Icarus.Domain.Entities;
using Icarus.Service.Helpers;
using Icarus.Service.Exceptions;
using Icarus.Service.DTOs.Assets;
using Microsoft.EntityFrameworkCore;
using Icarus.Data.IRepositories.Assets;
using Icarus.Service.Interfaces.Assets;

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
            .Where(a => a.Email.ToLower() == dto.Email.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (asset is not null)
            throw new IcarusException(409, "Asset is already exists");


        string logo = await MediaHelper.UploadFile(dto.Logo);

        var mappedAsset = _mapper.Map<Asset>(dto);
        mappedAsset.CreatedAt = DateTime.UtcNow;
        mappedAsset.Logo = logo;
        
        var createAsset = await _assetRepository.InsertAsync(mappedAsset);
        await _assetRepository.SaveAsync();

        await _assetRepository.SaveAsync();

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

        string logo = await MediaHelper.UploadFile(dto.Logo);

        var mappedAsset = _mapper.Map(dto, asset);
        mappedAsset.UpdatedAt = DateTime.UtcNow;
<<<<<<< HEAD
        mappedAsset.Logo = logoResult;
        var result = await _assetRepository.UpdateAsync(mappedAsset);
=======
        mappedAsset.Logo = logo;

        await _assetRepository.UpdateAsync(mappedAsset);
>>>>>>> f402d2ca69fb4d62a1a466115dfe5b9cd77079f6
        await _assetRepository.SaveAsync();

        return _mapper.Map<AssetForResultDto>(result);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var asset = await _assetRepository.SelectAll()
            .Where(a => a.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (asset is null)
            throw new IcarusException(404, "Asset is not found");

        var logoFullPath = Path.Combine(WebHostEnvironmentHelper.WebRootPath, asset.Logo);

        if (File.Exists(logoFullPath))
            File.Delete(logoFullPath);

<<<<<<< HEAD
        var result = await _assetRepository.DeleteAsync(id);
        await _assetRepository.SaveAsync();

        return result;
=======
        await _assetRepository.DeleteAsync(id);
        await _assetRepository.SaveAsync();

        return true;
>>>>>>> f402d2ca69fb4d62a1a466115dfe5b9cd77079f6
    }

    public async Task<IEnumerable<AssetForResultDto>> RetrieveAllAsync()
    {
        var assets = await _assetRepository.SelectAll()
            .AsNoTracking()
            .ToListAsync();
        
        return _mapper.Map<IEnumerable<AssetForResultDto>>(assets);
    }

    public async Task<AssetForResultDto> RetrieveByIdAsync(long id)
    {
        var asset = await _assetRepository.SelectAll().
          Where(a => a.Id == id).
          FirstOrDefaultAsync();

        if (asset is null)
            throw new IcarusException(404, "Asset is not found");

        return _mapper.Map<AssetForResultDto>(asset);
    }
}
