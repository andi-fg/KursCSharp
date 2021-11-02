using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgabe8_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1
            var listOfNames = new List<string>()
                {
                    "John Doe",
                    "Jane Doe",
                    "Jenna Doe",
                    "Joe Doe"
                };
            //Abfragesyntax
            var qnames = from name in listOfNames where name.Length <= 8 select name;
            //Methodensyntax
            var mnames = listOfNames.Where(name => name.Length <= 8);
            foreach(String s in qnames)
            {
                Console.WriteLine(s);
            }
            foreach(String s in mnames)
            {
                Console.WriteLine(s);
            }
            
            //2
            List<int> zahlen = new List<int>()
            {
                1, 2, 4, 7, 8, 16, 29, 32, 64, 128
            };
            //2.1
            var filter = zahlen.Where(n => n < 10);
            foreach(int i in filter)
            {
                Console.WriteLine(i);
            }
            //2.2
            var filter2 = zahlen.Where(n => n > 1 && n < 10 && n != 4);
            foreach (int i in filter2)
            {
                Console.WriteLine(i);
            }
            //2.3 
            List<int> nichtBenutzen = new List<int>
            {
                7,29
            };
            var filter3 = zahlen.Where(n => !nichtBenutzen.Contains(n));
            foreach(int i in filter3)
            {
                Console.WriteLine(i);
            }
            
            //2.4
            var personen = new List<Person> 
            {
                new Person(){Name= "John Schnee", Alter = 42 },
                new Person(){Name= "Jana Müller", Alter = 34 },
                new Person(){Name= "Hans Peter", Alter = 64 },
                new Person(){Name= "Jessic Müller", Alter = 8 }
            };
            var filterPersonen = personen.Where(person => person.Name.StartsWith("J") && person.Alter > 40);
            foreach(Person p in filterPersonen)
            {
                Console.WriteLine($"{p.Name} ist {p.Alter} Jahre alt");
            }
            //Konsole schliesst sich nicht gleich
            Console.ReadKey();
        }
    }
    class Person
    {
        public String Name { get; set; }
        public int Alter { get; set; }
    }
}
