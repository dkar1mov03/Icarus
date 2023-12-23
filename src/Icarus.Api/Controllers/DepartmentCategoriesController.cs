﻿using Icarus.Service.DTOs.Assets;
using Icarus.Service.DTOs.DepartmentCategories;
using Icarus.Service.Interfaces.DepartmentCategories;
using Microsoft.AspNetCore.Mvc;

namespace Icarus.Api.Controllers;

public class DepartmentCategoriesController : BaseController
{
    private readonly IDepartmentCategoryService _service;

    public DepartmentCategoriesController(IDepartmentCategoryService service)
    {
        _service = service;
    }
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] DepartmentCategoryForCreationDto dto)
           => Ok(await this._service.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._service.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] short id)
        => Ok(await this._service.RetrieveByIdAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] short id, [FromBody] DepartmentCategoryForUpdateDto dto)
        => Ok(await this._service.ModifyAsync(id, dto));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] short id)
       => Ok(await this._service.RemoveAsync(id));
}
