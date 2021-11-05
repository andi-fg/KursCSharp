using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6_AbstrakteKlassenMethoden
{
    abstract class Fahrzeug
    {
        public abstract void Beschreib();
        public virtual void Bewege()
        {
            Console.WriteLine("Das Fahrzeug bewegt sich");
        }
    }
}
