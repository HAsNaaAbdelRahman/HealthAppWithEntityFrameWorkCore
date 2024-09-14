using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class Exercise
{
    public int ExerciseId { get; set; }

    public string? ExerciseType { get; set; }

    public int GoalId { get; set; }

    public virtual Goal Goal { get; set; } = null!;
}
