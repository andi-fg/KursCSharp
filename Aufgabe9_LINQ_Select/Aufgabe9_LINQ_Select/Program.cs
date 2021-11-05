using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgabe9_LINQ_Select
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var personen = new List<Person>
            {
                new Person(){Name= "John Schnee", Alter = 8 , Mail = "jschnee@gmail.com"},
                new Person(){Name= "Jana Müller", Alter = 34, Mail = "jmueller@gmail.com" },
                new Person(){Name= "Hans Peter", Alter = 15, Mail = "hpeter@gmail.com" },
                new Person(){Name= "Jessic Müller", Alter = 42, Mail = "jesmueller@gmail.com " }
            };
            //1)
            Console.WriteLine("1)");
            var namen = personen.Select(person => person.Name).ToList();

            foreach(var s in namen)
            {
                Console.WriteLine(s);
            }
            //2)
            Console.WriteLine("2)");
            var personenListe = namen.Select(name => new Person { Name = name }).ToList();
            foreach(var p in personenListe)
            {
                Console.WriteLine(p.Name);
            }

            //3)
            Console.WriteLine("3)");
            var personenListeNeu = personen.Select(person => new { Name = person.Name, Alter = person.Alter }).ToList();
            //4)
            var personenListeAbfrage = (from person in personen select new { Name = person.Name, Alter = person.Alter }).ToList();
            foreach(var p in personenListeNeu)
            {
                Console.WriteLine($"{p.Name} ; {p.Alter}");
            }
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Alter { get; set; }
        public string Mail { get; set; }
    }
}
