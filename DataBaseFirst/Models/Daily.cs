using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class Daily
{
    public int DailyId { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<Meal> Meals { get; set; } = new List<Meal>();

    public virtual ICollection<Sleep> Sleeps { get; set; } = new List<Sleep>();

    public virtual User User { get; set; } = null!;
}
