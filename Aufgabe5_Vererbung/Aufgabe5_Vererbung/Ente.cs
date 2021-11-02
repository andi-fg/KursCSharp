using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5_Vererbung
{
    class Ente : Tier
    {
        public Ente(String name)
            : base(name)
        {
            
        }
        public override void sagHallo()
        {
            Console.WriteLine("Ich bin eine Ente");
        }
    }
}
