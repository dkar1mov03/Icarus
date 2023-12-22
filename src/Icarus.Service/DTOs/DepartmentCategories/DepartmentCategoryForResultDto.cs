using Icarus.Service.DTOs.Categories;
using Icarus.Service.DTOs.Departments;

namespace Icarus.Service.DTOs.DepartmentCategories;

public class DepartmentCategoryForResultDto
{
    public DepartmentForResultDto Department { get; set; }
    public CategoryForResultDto Category { get; set; }

    public string Description { get; set; }
}
