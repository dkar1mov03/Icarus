using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class Department : Auditable<long>
{
    public decimal Rating { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public ICollection<Request> Requests { get; set; }
    public ICollection<DepartmentCategory> DepartmentCategories { get; set; }
    public long AssetId { get; set; }
    public Asset Asset { get; set; }
}
