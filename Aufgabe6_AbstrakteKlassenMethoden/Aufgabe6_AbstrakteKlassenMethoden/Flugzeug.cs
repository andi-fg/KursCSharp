using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6_AbstrakteKlassenMethoden
{
    class Flugzeug : Fahrzeug
    {
        public override void beschreib()
        {
            Console.WriteLine("Ich bin ein Flugzeug");
        }
        public override void bewege()
        {
            Console.WriteLine("Ich fliege in den Süden");
        }
    }
}
