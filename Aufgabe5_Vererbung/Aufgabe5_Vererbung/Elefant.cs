using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5_Vererbung
{
    class Elefant : Tier
    {
        public Elefant(String name)
            : base(name)
        {
           
        }
        public override void sagHallo()
        {
            base.sagHallo();
            Console.WriteLine("Ich bin ein Elefant");
        }
    }
}
