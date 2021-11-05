using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5_Vererbung
{
    class Ente : Tier
    {
        public Ente(string name)
            : base(name)
        {
            
        }
        public override void SagHallo()
        {
            Console.WriteLine($"Ich bin eine Ente Namens {Name}");
        }
    }
}
