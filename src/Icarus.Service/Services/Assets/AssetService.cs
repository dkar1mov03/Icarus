using AutoMapper;
using Icarus.Data.IRepositories.Assets;
using Icarus.Domain.Entities;
using Icarus.Service.DTOs.Assets;
using Icarus.Service.Exceptions;
using Icarus.Service.Helpers;
using Icarus.Service.Interfaces.Assets;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

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

        var logoFileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Logo.FileName);
        var logoRootPath = Path.Combine(WebHostEnvironmentHelper.WebRootPath, "Media", "Logos", logoFileName);
        using (var stream = new FileStream(logoRootPath, FileMode.Create))
        {
            await dto.Logo.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string logoResult = Path.Combine("Media", "Logos", logoFileName);

        var mappedAsset = _mapper.Map<Asset>(dto);
        mappedAsset.CreatedAt = DateTime.UtcNow;
        mappedAsset.Logo = logoResult;
        
        var createAsset = await _assetRepository.InsertAsync(mappedAsset);
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

        var logoFullPath = Path.Combine(WebHostEnvironmentHelper.WebRootPath, asset.Logo);

        if (File.Exists(logoFullPath))
            File.Delete(logoFullPath);

        var logoFileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Logo.FileName);
        var logoRootPath = Path.Combine(WebHostEnvironmentHelper.WebRootPath, "Media", "Logos", logoFileName);
        using (var stream = new FileStream(logoRootPath, FileMode.Create))
        {
            await dto.Logo.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string logoResult = Path.Combine("Media", "Logos", logoFileName);

        var mappedAsset = _mapper.Map(dto, asset);
        mappedAsset.UpdatedAt = DateTime.UtcNow;
        mappedAsset.Logo = logoResult;
        var result = await _assetRepository.UpdateAsync(mappedAsset);
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

        var result = await _assetRepository.DeleteAsync(id);
        await _assetRepository.SaveAsync();

        return result;
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
