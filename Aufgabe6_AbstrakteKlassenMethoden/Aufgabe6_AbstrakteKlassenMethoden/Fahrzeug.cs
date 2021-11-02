using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6_AbstrakteKlassenMethoden
{
    abstract class Fahrzeug
    {
        public abstract void beschreib();
        public virtual void bewege()
        {
            Console.WriteLine("Das Fahrzeug bewegt sich");
        }
    }
}
