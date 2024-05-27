using System;
using System.Collections.Generic;

namespace Khumalo_Craft.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? Surname { get; set; }

    public string? Password { get; set; }

    public bool? IsAdmin { get; set; }
}
