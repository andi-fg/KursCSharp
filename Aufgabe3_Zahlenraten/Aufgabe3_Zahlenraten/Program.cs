using System;

namespace Aufgabe3_Zahlenraten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen deklaration
            int intZahl = 0;
            int intVersuche = 0;
            int intZufall = 0;
            string strBeenden;
            Random Random = new Random();


            do
            {
                intVersuche = 0;

                //Zufallszahl wird generiert
                intZufall = Random.Next(1, 101);
                intZahl = 0;
                //Fenster wird gecleart
                Console.Clear();
                do
                {
                    do
                    {
                        try
                        {
                            Console.Write("Bitte eine Zahl von 1 - 100 eingeben: ");
                            intZahl = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            intZahl = 0;
                        }
                    } while (intZahl < 1 || intZahl > 100);

                    //intVersuche wird hochgezählt
                    intVersuche = intVersuche + 1;

                    //Wenn die Zahlen nicht stimmen
                    if (intZufall != intZahl)
                    {
                        if (intZahl < intZufall)
                        {
                            Console.WriteLine("Die Zahl ist grösser als " + intZahl);
                        }
                        else
                        {
                            Console.WriteLine("Die Zahl ist kleiner als " + intZahl);
                        }
                    }

                } while (intZufall != intZahl);


                Console.WriteLine("Sie haben " + intVersuche + " Versuche gebraucht");

                Console.Write("Spiel beenden? j = ja, andereEingabe = nein: ");
                strBeenden = Console.ReadLine();
                strBeenden = strBeenden.ToLower();

            } while (strBeenden != "j");

            //Fenster soll sich nicht schliessen
            Console.ReadKey();
        }
    }
}
