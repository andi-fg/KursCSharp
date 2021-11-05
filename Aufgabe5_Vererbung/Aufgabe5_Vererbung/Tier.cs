using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5_Vererbung
{
    class Tier
    {
        public string Name { get; set; }
        
        public Tier(string name)
        {
            this.Name = name;
        }
        public virtual void SagHallo()
        {
            Console.WriteLine($"Guten Tag ich bin {Name}");
        }
    }
}
