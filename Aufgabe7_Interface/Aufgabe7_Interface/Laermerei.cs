using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe7_Interface
{
    class Laermerei
    {
        private List<Laermer> orchester = new List<Laermer>();
        public void addLaermer(Laermer laermer)
        {
            orchester.Add(laermer);
        }
        public void laerme()
        {
            foreach(Laermer laermer in orchester)
            {
                laermer.gibLaut();
            }
        }
    }
}
