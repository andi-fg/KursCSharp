using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5_Vererbung
{
    class Tier
    {
        public String name { get; set; }
        
        public Tier(String name)
        {
            this.name = name;
        }
        public virtual void sagHallo()
        {
            Console.WriteLine($"Guten Tag ich bin {name}");
        }
    }
}
