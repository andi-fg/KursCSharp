using System;
using System.Collections.Generic;

namespace Aufgabe2_Listen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1 String List
            //Teil 1
            var names = new List<string> { "Eric", "Anna", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hallo {name}");
            }
            //Teil 2 add und Remove
            names.Add("Max");
            names.Add("Lara");
            names.Remove("Eric");
            Console.WriteLine($"Die Liste hat {names.Count} Einträge");
            Console.WriteLine($"Die Namen {names[2]} und {names[3]} wurden hinzugefügt");
            //Teil 3 Index of
            var index = names.IndexOf("Lara");
            if(index != -1)
            {
                Console.WriteLine($"Der Name{names[index]} hat den Index {index}");
            }

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"Wenn ein Item nicht gefunden werden kann, IndexOf gibt {notFound} zurück");
            //Teil 4 sort 
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hallo {name}");
            }
            //Aufgabe 2 Fibonacci
            var fibonacciNumbers = new List<int> { 1, 1 };
            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
            //Konsole geht nicht direkt zu
            Console.ReadKey();
        }
    }
}
