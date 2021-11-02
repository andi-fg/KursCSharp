using System;

namespace Aufgabe4_KlassenMethodenVariablen
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund bernadiner = new Hund("Bernadiner");
            Hund huskey = new Hund("Huskey");
            bernadiner.fellFarbe = "Braun";
            huskey.fellFarbe = "Weiss";
            Console.WriteLine($"Der {huskey.rasse} hat die Farbe {huskey.fellFarbe} und der {bernadiner.rasse} hat die Farbe {bernadiner.fellFarbe}.");
            huskey.belle();
            huskey.belle("Knurrrr");
            huskey.belle("Knurr", 5);

            //Fenster nicht direkt schliessen
            Console.ReadKey();
        }
    }
}
