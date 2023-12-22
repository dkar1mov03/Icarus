using Icarus.Domain.Entities;

namespace Icarus.Service.DTOs.Categories;

public class CategoryForResultDto
{
    public string Name { get; set; }
    public ICollection<DepartmentCategory> DepartmentCategories { get; set; }
}
