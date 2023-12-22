﻿using Icarus.Domain.Enums;

namespace Icarus.Service.DTOs.Users
{
    public class UserForCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }

    }
}
