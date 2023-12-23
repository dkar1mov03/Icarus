﻿using Icarus.Domain.Entities;

namespace Icarus.Service.DTOs.Departments;

public class DepartmentForCreationDto
{
    public decimal Rating { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
}
