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
            hans.SagHallo();
            Console.WriteLine();
            anna.SagHallo();
            Console.WriteLine();
            dumbo.SagHallo();
            Console.WriteLine();
            Tier ruedi = new Tier("Ruedi");
            ruedi.SagHallo();
            //Fenster geht nicht direkt zu
            Console.ReadKey();
        }
    }
}
