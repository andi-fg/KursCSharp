using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6_AbstrakteKlassenMethoden
{
    class Auto : Fahrzeug
    {
        public override void Beschreib()
        {
            Console.WriteLine("Ich bin ein Auto");
        }
    }
}
