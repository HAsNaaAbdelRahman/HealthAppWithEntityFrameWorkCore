﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
  
    public class UserHealth
    {

        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }


    }
}
