using Icarus.Service.Helpers;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Icarus.Service.DTOs.Users
{
    public class UserForCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [IcarusEmailAttribute]
        public string Email { get; set; }

        [PhoneAttribute]
        public string Phone { get; set; }
        public string Password { get; set; }
        public IFormFile Image { get; set; }

    }
}
