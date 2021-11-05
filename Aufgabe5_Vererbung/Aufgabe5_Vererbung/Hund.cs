using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5_Vererbung
{
    class Hund : Tier
    {
        public string Rasse { get; }
        public string FellFarbe { get; set; }

        public Hund(string rasse, string name) 
            : base(name)
        {
            this.Rasse = rasse;
        }
        public void Belle()
        {
            Console.WriteLine("Wuff");
        }
        public void Belle(string laut)
        {
            Console.WriteLine(laut);
        }
        public void Belle(string laut, int anzahl)
        {
            for(int i = 1; i <= anzahl; i++)
            {
                Console.WriteLine(laut);
            }
        }
    }
}
