using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe7_Interface
{
    class Hund : Haustier
    {
        public override void GibLaut()
        {
            Console.WriteLine("Wuff");
        }
    }
}
