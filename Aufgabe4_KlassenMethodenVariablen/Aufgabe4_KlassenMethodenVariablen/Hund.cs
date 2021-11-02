using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4_KlassenMethodenVariablen
{
    class Hund
    {
        public String rasse { get; }
        public String fellFarbe { get; set; }

        public Hund(String rasse)
        {
            this.rasse = rasse;
        }
        public void belle()
        {
            Console.WriteLine("Wuff");
        }
        public void belle(String laut)
        {
            Console.WriteLine(laut);
        }
        public void belle(String laut, int anzahl)
        {
            for(int i = 1; i <= anzahl; i++)
            {
                Console.WriteLine(laut);
            }
        }
    }
}
