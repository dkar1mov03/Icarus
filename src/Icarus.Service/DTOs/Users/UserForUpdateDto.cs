﻿using Icarus.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace Icarus.Service.DTOs.Users
{
    public class UserForUpdateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public IFormFile Image { get; set; }
    }
}
