using Icarus.Domain.Enums;
using Icarus.Domain.Entities;

namespace Icarus.Service.DTOs.Requests;
public class RequestForResultDto
{
    public long UserId { get; set; }
    public User FromWho { get; set; }
    public long DepartmentId { get; set; }
    public Department WhichDepartment { get; set; }
    public string RequestBody { get; set; }
    public string RequestTitle { get; set; }
    public Status Status { get; set; }
}
