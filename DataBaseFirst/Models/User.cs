using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public int Age { get; set; }

    public virtual ICollection<Authentication> Authentications { get; set; } = new List<Authentication>();

    public virtual ICollection<Daily> Dailies { get; set; } = new List<Daily>();
}
