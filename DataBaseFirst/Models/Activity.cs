using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class Activity
{
    public int ActivityId { get; set; }

    public int? WaterTake { get; set; }

    public DateOnly Data { get; set; }

    public int Id { get; set; }

    public virtual Daily IdNavigation { get; set; } = null!;
}
