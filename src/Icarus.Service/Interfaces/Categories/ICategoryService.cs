using Icarus.Service.DTOs.Categories;

namespace Icarus.Service.Interfaces.Categories;

public interface ICategoryService
{
    Task<bool> RemoveAsync(short id);
    Task<CategoryForResultDto> RetrieveByIdAsync(short id);
    Task<CategoryForResultDto> CreateAsync(CategoryForCreationDto dto);
    Task<CategoryForResultDto> ModifyAsync(short id, CategoryForUpdateDto dto);
    Task<IEnumerable<CategoryForResultDto>> RetrieveAllAsync();
}
