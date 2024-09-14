using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string ExerciseType { get; set; }

        public int GoalId { get; set; }

        public virtual Goal goal { get; set; }

    }
}
