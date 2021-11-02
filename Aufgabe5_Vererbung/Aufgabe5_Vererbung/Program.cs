using System;

namespace Aufgabe5_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund hans = new Hund("Huskey", "Alice");
            Ente anna = new Ente("Hans");
            Elefant dumbo = new Elefant("Dumbo");
            hans.sagHallo();
            Console.WriteLine();
            anna.sagHallo();
            Console.WriteLine();
            dumbo.sagHallo();
            Console.WriteLine();
            Tier ruedi = new Tier("Ruedi");
            ruedi.sagHallo();
            //Fenster geht nicht direkt zu
            Console.ReadKey();
        }
    }
}
