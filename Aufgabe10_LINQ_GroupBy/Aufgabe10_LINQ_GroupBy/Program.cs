using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgabe10_LINQ_GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var personen = new List<Person>
            {
                new Person(){Name= "John Schnee", Alter = 42, Land = "USA" },
                new Person(){Name= "Jana Müller", Alter = 18, Land = "Schweiz" },
                new Person(){Name= "Hans Peter", Alter = 64, Land = "Schweiz" },
                new Person(){Name= "Jessic Müller", Alter = 8, Land = "USA" },
                new Person(){Name= "Mara Meier", Alter = 18, Land = "Schweiz" }
            };
            //1
            var landerGruppe = personen.GroupBy(person => person.Land);
            foreach(var land in landerGruppe)
            {
                Console.WriteLine($"Personen von {land.Key}");
                foreach(var person in land)
                {
                    Console.WriteLine($"* {person.Name}");
                }
            }
            //2
            var altersGruppe = personen.GroupBy(person => person.AltersGruppe());
            foreach(var gruppe in altersGruppe)
            {
                Console.WriteLine($"{gruppe.Key}: ");
                foreach(var person in gruppe)
                {
                    Console.WriteLine($"* {person.Name} [{person.Alter} jahren]");
                }
            }
            //3
            var gruppeLandAlter = personen.GroupBy(person => new {person.Land , person.Alter });
            foreach(var gruppe in gruppeLandAlter)
            {
                Console.WriteLine($"Person von {gruppe.Key.Land} im Alter von {gruppe.Key.Alter}");
                foreach(var person in gruppe)
                {
                    Console.WriteLine($"* {person.Name} [{person.Alter}]");
                }
            }
            //Konsole schlisst nicht gleich
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Alter { get; set; }
        public String Land { get; set; }

        public string AltersGruppe()
        {
            if(this.Alter < 13)
            {
                return "Kind";
            }else if(this.Alter < 21)
            {
                return "Teenager";
            }
            return "Erwachsen";
        }
    }
}
