using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class Meal
{
    public int MealId { get; set; }

    public string MealName { get; set; } = null!;

    public int? Quentity { get; set; }

    public double? Calories { get; set; }

    public DateOnly DateMeal { get; set; }

    public int Id { get; set; }

    public virtual Daily IdNavigation { get; set; } = null!;
}
