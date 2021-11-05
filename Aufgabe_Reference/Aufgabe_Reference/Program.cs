using System;

namespace Aufgabe_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 10;
            Console.WriteLine(i);
            MethodReference(ref i);
            Console.WriteLine(i);
            int k;
            MethodOut(out k);
            Console.WriteLine(k);
           //Fehler man darf nich verändern MethodIn(in i);

            Console.ReadKey();
        }

        static void MethodReference(ref int i)
        {
            i += 10;
        }
        static void MethodIn(in int i)
        {
            //i += 10;
        }
        static void MethodOut(out int i)
        {
            i = 30;
        }
    }
}
