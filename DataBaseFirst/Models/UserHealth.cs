using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class UserHealth
{
    public decimal? Weight { get; set; }

    public decimal? Height { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
