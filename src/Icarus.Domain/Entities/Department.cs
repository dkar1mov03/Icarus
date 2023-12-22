namespace Icarus.Domain.Entities;
public class Department:Asset
{
    public ICollection<DepartmentCategory> DepartmentCategories { get; set; }
}
