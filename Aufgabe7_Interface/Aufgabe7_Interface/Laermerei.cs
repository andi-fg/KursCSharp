using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe7_Interface
{
    class Laermerei
    {
        private List<Laermer> Orchester = new List<Laermer>();
        public void AddLaermer(Laermer laermer)
        {
            Orchester.Add(laermer);
        }
        public void Laerme()
        {
            foreach(Laermer laermer in Orchester)
            {
                laermer.GibLaut();
            }
        }
    }
}
