using Icarus.Service.DTOs.Categories;
using Icarus.Service.Interfaces.Categories;
using Microsoft.AspNetCore.Mvc;

namespace Icarus.Api.Controllers.Categories
{
    public class CategoriesController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromQuery] CategoryForCreationDto dto)
            => Ok(await this._categoryService.CreateAsync(dto));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(await _categoryService.RetrieveAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] short id)
            => Ok(await this._categoryService.RetrieveByIdAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromRoute(Name = "id")][FromQuery] short id, CategoryForUpdateDto dto)
            => Ok(await this._categoryService.ModifyAsync(id, dto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] short id)
            => Ok(await this._categoryService.RemoveAsync(id));
    }

}
