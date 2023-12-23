﻿using Icarus.Domain.Enums;
using Icarus.Domain.Commons;

namespace Icarus.Domain.Entities;
public class User : Auditable<long>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public string Image { get; set; }
    public Role Role { get; set; }

}
