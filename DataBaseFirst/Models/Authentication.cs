using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class Authentication
{
    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
