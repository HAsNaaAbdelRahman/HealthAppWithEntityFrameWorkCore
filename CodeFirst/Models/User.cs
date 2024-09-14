using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Gender { get; set; }
        public int age { get; set; }
        public virtual List<Authentication> Authentications { get; set; }
        public virtual List<Daily> Dailies { get; set; }

    }
}
