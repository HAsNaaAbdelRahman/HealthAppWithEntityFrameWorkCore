using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Authentication
    {
        public string UserName { get; set; }
       public string Password { get; set; }
        [Key]
        public string Email { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}
