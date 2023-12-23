using AutoMapper;
using Icarus.Data.IRepositories;
using Icarus.Service.DTOs.DepartmentCategories;
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
        throw new NotImplementedException();
    }


    public Task<DepartmentCategoryForResultDto> ModifyAsync(long id, DepartmentCategoryForUpdateDto dto)
    {
        throw new NotImplementedException();
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
