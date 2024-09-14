using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class Sleep
{
    public int SleepId { get; set; }

    public TimeOnly? StartH { get; set; }

    public TimeOnly? EndH { get; set; }

    public decimal? Dueration { get; set; }

    public int Id { get; set; }

    public virtual Daily IdNavigation { get; set; } = null!;
}
