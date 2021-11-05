using System;

namespace Aufgabe6_AbstrakteKlassenMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Beschreib();
            auto.Bewege();

            Flugzeug flugzeug = new Flugzeug();
            flugzeug.Beschreib();
            flugzeug.Bewege();

            Console.ReadKey();
        }
    }
}
