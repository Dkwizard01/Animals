using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daenet_OOP
{  
   
    internal class Bird : Animal
    {
        public int Wings { get; set; }
        public Bird(string name, int id, int legs, string description, int wings) : base(name,"bird", id, legs, description)
        {
            this.Wings = wings;
        }
    }
}
