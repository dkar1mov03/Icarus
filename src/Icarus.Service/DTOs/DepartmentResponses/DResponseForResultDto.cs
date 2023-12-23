using Icarus.Domain.Entities;

namespace Icarus.Service.DTOs.DepartmentResponses;
public class DResponseForResultDto
{
    public long RequestId { get; set; }
    public Request Request { get; set; }
    public long DepartmentId { get; set; }
    public Department Department { get; set; }
    public string ResponceBody { get; set; }
}
