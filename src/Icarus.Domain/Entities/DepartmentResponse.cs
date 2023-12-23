﻿
using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class DepartmentResponse : Auditable<long>
{
    public long RequestId { get; set; }
    public Request Request { get; set; }
    public long DepartmentId { get; set; }
    public Department Department { get; set; }

    public string ResponceBody { get; set; }
}
