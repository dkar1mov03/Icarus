namespace Icarus.Domain.Entities;
public class Department : Asset
{
    public decimal Rating { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public ICollection<DepartmentCategory> DepartmentCategories { get; set; }
}
