using Microsoft.AspNetCore.Mvc;
using Icarus.Service.DTOs.Users;
using Icarus.Service.Interfaces.Users;

namespace Icarus.Api.Controllers.Users
{
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromForm] UserForCreationDto dto)
            => Ok(await this._userService.AddAsync(dto));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(await this._userService.RetrieveAllAsync());


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
            => Ok(await this._userService.RetrieveByIdAsync(id));


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromForm] UserForUpdateDto dto)
            => Ok(await this._userService.ModifyAsync(id, dto));


        [HttpDelete("{id}")]
         public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
            => Ok(await this._userService.RemoveAsync(id));


        [HttpGet("email")]
        public async Task<IActionResult> GetByEmailAsync(string email)
            => Ok(await this._userService.RetrieveByEmailAsync(email));
    }
}
