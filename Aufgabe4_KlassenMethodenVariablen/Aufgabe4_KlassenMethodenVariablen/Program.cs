using System;

namespace Aufgabe4_KlassenMethodenVariablen
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund bernadiner = new Hund("Bernadiner");
            Hund huskey = new Hund("Huskey");
            bernadiner.FellFarbe = "Braun";
            huskey.FellFarbe = "Weiss";
            Console.WriteLine($"Der {huskey.Rasse} hat die Farbe {huskey.FellFarbe} und der {bernadiner.Rasse} hat die Farbe {bernadiner.FellFarbe}.");
            huskey.Belle();
            huskey.Belle("Knurrrr");
            huskey.Belle("Knurr", 5);

            //Fenster nicht direkt schliessen
            Console.ReadKey();
        }
    }
}
