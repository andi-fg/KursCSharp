using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe7_Interface
{
    class Katze : Haustier
    {
        public override void gibLaut()
        {
            Console.WriteLine("Miau");
        }
    }
}
