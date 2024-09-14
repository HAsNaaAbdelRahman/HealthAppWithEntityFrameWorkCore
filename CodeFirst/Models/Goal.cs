using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
 
    public class Goal
    {
        public int Id { get; set; }
        public string GoalType { get; set; } 

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
