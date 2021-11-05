using System;

namespace Aufgabe7_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Laermerei l = new Laermerei();
            l.AddLaermer(new Donner());
            l.AddLaermer(new Auto());
            l.AddLaermer(new Katze());
            l.AddLaermer(new Hund());
            l.Laerme();

            //Fenster schliesst nicht gleich
            Console.ReadKey();
        }
    }
}
