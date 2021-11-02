using System;

namespace Aufgabe7_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Laermerei l = new Laermerei();
            l.addLaermer(new Donner());
            l.addLaermer(new Auto());
            l.addLaermer(new Katze());
            l.addLaermer(new Hund());
            l.laerme();

            //Fenster schliesst nicht gleich
            Console.ReadKey();
        }
    }
}
