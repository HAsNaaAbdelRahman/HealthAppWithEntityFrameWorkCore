using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{

    public class Meal
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public int Quentity {  get; set; }
        public float Calories { get; set; }
        public DateOnly DateMeal { get; set; }

        public virtual Daily Daily { get; set; }
        public int DailyId { get; set; }

    }
}
