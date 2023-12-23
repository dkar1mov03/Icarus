using AutoMapper;
using Icarus.Data.IRepositories;
using Icarus.Domain.Entities;
using Icarus.Service.DTOs.DepartmentCategories;
using Icarus.Service.Exceptions;
using Icarus.Service.Interfaces.DepartmentCategories;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Service.Services.DepartmentCategories;

public class DepartmentCategoryService : IDepartmentCategoryService
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IDepartmentCategoryRepository _departmentCategoryRepository;
    public DepartmentCategoryService(IMapper mapper, 
        ICategoryRepository categoryRepository, 
        IDepartmentCategoryRepository departmentCategoryRepository)
    {
        _mapper = mapper;
        _categoryRepository = categoryRepository;
        _departmentCategoryRepository = departmentCategoryRepository;
    }

    // private readonly IDepartmentRepository
    public async Task<DepartmentCategoryForResultDto> CreateAsync(DepartmentCategoryForCreationDto dto)
    {
        var category = await _categoryRepository.SelectAll()
            .Where(c => c.Id == dto.CategoryId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (category is null)
            throw new IcarusException(404, "Category is not found");

        var mapped = _mapper.Map<DepartmentCategory>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        var result = await _departmentCategoryRepository.InsertAsync(mapped);

        return _mapper.Map<DepartmentCategoryForResultDto>(result);
    }

    public async Task<DepartmentCategoryForResultDto> ModifyAsync(long id, DepartmentCategoryForUpdateDto dto)
    {
        var category = await _categoryRepository.SelectAll()
            .Where(c => c.Id == dto.CategoryId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (category is null)
            throw new IcarusException(404, "Category is not found");

        var departmentCategory = await _departmentCategoryRepository.SelectAll()
            .Where(dc => dc.Id == id)
            .FirstOrDefaultAsync();
        if (departmentCategory is null)
            throw new IcarusException(404, "Department cAtegory is not found");

        var mapped = _mapper.Map(dto, departmentCategory);
        mapped.UpdatedAt = DateTime.UtcNow;
        var result = await _departmentCategoryRepository.UpdateAsync(mapped);

        return _mapper.Map<DepartmentCategoryForResultDto>(result);
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DepartmentCategoryForResultDto>> RetrieveAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DepartmentCategoryForResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }
}
