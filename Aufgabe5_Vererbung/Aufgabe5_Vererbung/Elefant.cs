using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5_Vererbung
{
    class Elefant : Tier
    {
        public Elefant(string name)
            : base(name)
        {
           
        }
        public override void SagHallo()
        {
            base.SagHallo();
            Console.WriteLine("Ich bin ein Elefant");
        }
    }
}
