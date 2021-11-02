using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgabe8_LINQ_OrderbyThenby
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1
            var zahlen = new List<int> 
            {
                1, 2, 4, 7, 8, 16, 29, 32, 64, 128
            };
            var aufsteigend = zahlen.OrderBy(zahl => zahl).ToList();
            var absteigend = zahlen.OrderByDescending(zahl => zahl).ToList();
            for(int i = 0; i < zahlen.Count; i++)
            {
                Console.WriteLine($"aufsteigend: {aufsteigend[i]} ; absteigend: {absteigend[i]}");
            }
            //2
            var städte = new List<String>
            {
                "Amsterdam", "Zürich", "Brüssel", "New York", "Basel", "Wien", "Berlin", "Paris"
            };
            var stadtAuf = städte.OrderBy(stadt => stadt).ToList();
            var stadtAb = städte.OrderByDescending(stadt => stadt).ToList();
            for(int i = 0; i < städte.Count(); i++)
            {
                Console.WriteLine($"aufsteigend: {stadtAuf[i]} ; absteigend: {stadtAb[i]}");
            }
            //3,4
            var personen = new List<Person>
            {
                new Person(){Name= "John Schnee", Alter = 8 },
                new Person(){Name= "Jana Müller", Alter = 34 },
                new Person(){Name= "Hans Peter", Alter = 34 },
                new Person(){Name= "Jessic Müller", Alter = 8 }
            };
            //3
            //var sortiert = personen.OrderBy(person => person.Alter).ThenBy(person => person.Name).ToList();
            //4
            var sortiert = personen.OrderBy(person => person.Alter).ThenByDescending(person => person.Name).ToList();
            foreach (Person p in sortiert)
            {
                Console.WriteLine($"{p.Name} ist {p.Alter} Jahre alt");
            }
            Console.ReadKey();
        }
    }
    class Person
    {
        public String Name { get; set; }
        public int Alter { get; set; }
    }
}
