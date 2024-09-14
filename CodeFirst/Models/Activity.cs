using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeFirst.Models
{
    public class Activity
    {

        public int Id { get; set; }
        public int WaterTake {  get; set; }
        public DateOnly date {  get; set; }

        public Daily Daily { get; set; }
        public int DailyId { get; set; }

    }
}
