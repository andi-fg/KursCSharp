using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aufgabe_SyncAsync_Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task<Kaffee> kaffeTask= MachKaffeeAsync();
            Task<Ei> taskEi = MachEiAsync();
            Task<Speck> taskSpeck = MachSpeckAsync();
            Task<Toast> taskToast = MachToastAsync();

           /* Kaffee tasse = await kaffeTask;
            Console.WriteLine("Kaffe ist fertig");
            
            Ei ei = await taskEi;
            Console.WriteLine("Ei ist fertig");

            Toast toast = await taskToast;
            Console.WriteLine("Toast ist fertig");

            Speck speck = await taskSpeck;
            Console.WriteLine("Speck ist fertig");*/

            var breakfastTasks = new List<Task> { kaffeTask, taskEi, taskToast, taskSpeck };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == taskEi)
                {
                    Console.WriteLine("Ei ist fertig");
                }
                else if (finishedTask == taskSpeck)
                {
                    Console.WriteLine("Speck ist fertig");
                }
                else if (finishedTask == taskToast)
                {
                    Console.WriteLine("Toast ist fertig");
                }
                else if(finishedTask == kaffeTask)
                {
                    Console.WriteLine("Kaffe ist fertig");
                }
                breakfastTasks.Remove(finishedTask);
            }

            Saft saft = MachSaft();
            Console.WriteLine("Saft ist fertig");
            Console.WriteLine("Frühstück ist fertig");
            Console.ReadKey();
        }
        private static async Task<Kaffee> MachKaffeeAsync()
        {
            Console.WriteLine("Koche Kaffee");
            await Task.Delay(3000);
            return new Kaffee();
        }
        private static async Task<Speck> MachSpeckAsync()
        {
            Console.WriteLine("Speck auf einer Seite anbraten");
            await Task.Delay(3000);
            Console.WriteLine("Speck von der anderen Seite anbraten");
            await Task.Delay(3000);
            return new Speck();
        }
        private static async Task<Ei> MachEiAsync()
        {
            Console.WriteLine("Eier aufschlagen und anbraten");
            await Task.Delay(4000);
            return new Ei();
        }
        private static async Task<Toast> MachToastAsync()
        {
            Console.WriteLine("Toast in den Toaster tun");
            await Task.Delay(4000);
            return new Toast();
        }
        private static Saft MachSaft()
        {
            Console.WriteLine("Orangensaft einschänken");
            return new Saft();
        }
    }
}
