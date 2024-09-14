using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{

    public class Sleep
    {
        public int Id { get; set; }
        public TimeOnly startHours {  get; set; }
        public TimeOnly endHours { get; set; }
        public decimal Dueration {  get; set; }

        public virtual Daily Daily { get; set; }

        public int DailyId { get; set; }
    }
}
