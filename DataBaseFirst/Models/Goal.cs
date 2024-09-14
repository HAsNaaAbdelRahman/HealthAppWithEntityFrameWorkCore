using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class Goal
{
    public int GoalId { get; set; }

    public string GoalType { get; set; } = null!;

    public virtual ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
}
