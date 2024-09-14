using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Daily
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Sleep sleep { get; set; }
        public virtual List< Meal> Meal { get; set; }
        public virtual List<Activity> Activity { get; set; }
        public virtual List<User> User { get; set; }
    }
}
