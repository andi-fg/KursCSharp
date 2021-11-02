using System;

namespace Aufgabe6_AbstrakteKlassenMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.beschreib();
            auto.bewege();

            Flugzeug flugzeug = new Flugzeug();
            flugzeug.beschreib();
            flugzeug.bewege();

            Console.ReadKey();
        }
    }
}
