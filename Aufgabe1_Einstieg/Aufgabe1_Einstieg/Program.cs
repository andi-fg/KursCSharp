using System;

namespace Aufgabe1_Einstieg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufagbe 1
            Console.WriteLine("Hallo Welt!");

            //Aufgabe 2 
            Console.Write("Geben Sie bitte Ihren Namen ein: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hallo {name}");

            //Aufgabe 3 For Schleife
            int zahl;
            do
            {
                Console.Write("Geben Sie bitte die Letzte Zahl von 1-n ein: ");
                try
                {
                    zahl = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Sie haben keine ganze Zahl eingegeben.");
                }
            } while (true);
            for (int i = 1; i <= zahl; i++)
            {
                Console.WriteLine(i);
            }

            //Aufgabe 4 if Schleife
            int grad;
            do
            {
                Console.Write("Wie viel Grad ist es draussen?: ");
                try
                {
                    grad = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Sie haben keine ganze Zahl eingegeben.");
                }
            } while (true);
            if(grad >= 18)
            {
                Console.WriteLine("Ein T-Shirt reicht");
            }else if(grad > 8)
            {
                Console.WriteLine("Eine normale Jacke reicht");
            }
            else
            {
                Console.WriteLine("Eine Winterjacke braucht es");
            }
            //Fenster soll sich nicht direkt schliessen
            Console.ReadKey();
        }
    }
}
