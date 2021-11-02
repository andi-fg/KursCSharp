using System;
using System.Threading.Tasks;

namespace Aufgabe_SyncAsnyc_Sync
{
    class Program
    {
        static void Main(string[] args)
        {
            Kaffee tasse = MachKaffee();
            Console.WriteLine("Kaffe ist fertig");
            Ei ei = MachEi();
            Console.WriteLine("Ei ist fertig");
            Speck speck = MachSpeck();
            Console.WriteLine("Speck ist fertig");
            Toast toast = MachToast();
            Console.WriteLine("Toast ist fertig");
            Saft saft = MachSaft();
            Console.WriteLine("Saft ist fertig");
            Console.WriteLine("Frühstück ist fertig");
            Console.ReadKey();
        }
        private static Kaffee MachKaffee()
        {
            Console.WriteLine("Koche Kaffee");
            Task.Delay(3000).Wait();
            return new Kaffee();
        }
        private static Speck MachSpeck()
        {
            Console.WriteLine("Speck auf einer Seite anbraten");
            Task.Delay(3000).Wait();
            Console.WriteLine("Speck von der anderen Seite anbraten");
            Task.Delay(3000).Wait();
            return new Speck();
        }
        private static Ei MachEi()
        {
            Console.WriteLine("Eier aufschlagen und anbraten");
            Task.Delay(4000).Wait();
            return new Ei();
        }
        private static Toast MachToast()
        {
            Console.WriteLine("Toast in den Toaster tun");
            Task.Delay(4000).Wait();
            return new Toast();
        }
        private static Saft MachSaft()
        {
            Console.WriteLine("Orangensaft einschänken");
            return new Saft();
        }

    }
}
