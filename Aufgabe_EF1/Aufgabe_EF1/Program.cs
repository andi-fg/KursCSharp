using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Aufgabe_EF1
{
    class Program
    {
        static void Main(string[] args)
        {
            //erste autoren erstellen wenn in DB noch keine Autoren sind und in db speichern
            using(var db = new BibliothekDb())
            {
                if(db.Autor.Count() == 0)
                {
                    var king = new Autor();
                    king.Name = "King";
                    king.Vorname = "Stephan";
                    DateTime gebKing = new DateTime(1947, 9, 21);
                    king.Geburtsdatum = gebKing;

                    var meyer = new Autor();
                    meyer.Name = "Meyer";
                    meyer.Vorname = "Stephenie";
                    DateTime gebMeyer = new DateTime(1973, 12, 24);
                    meyer.Geburtsdatum = gebMeyer;
                    
                    db.Autor.Add(king);
                    db.Autor.Add(meyer);

                    db.SaveChanges();
                }
               
            }
            //Autoren von DB auf Konsole ausgeben
            using(var db = new BibliothekDb())
            {
                foreach(var autor in db.Autor)
                {
                    var geb = autor.Geburtsdatum.ToString("dd/MM/yyyy");
                    Console.WriteLine($"{autor.AutorID}, {autor.Name}, {autor.Vorname}, {geb}");
                }
            }
            //Autor nach name suchen mit LINQ
            using(var db = new BibliothekDb())
            {
                var autoren = db.Autor.Where(autor => autor.Name.Contains("King")).ToList();
                foreach (var autor in autoren)
                {
                    var geb = autor.Geburtsdatum.ToString("dd/MM/yyyy");
                    Console.WriteLine($"{autor.AutorID}, {autor.Name}, {autor.Vorname}, {geb}");
                }
            }

            //Bücher erstellen wenn es noch keine hat
            using(var db = new BibliothekDb())
            {
                if (db.Buch.Count() == 0) 
                {
                    //Bücher King
                    Buch sie = new Buch();
                    sie.Titel = "Sie";
                    sie.AutorId = 1;

                    Buch carrie = new Buch();
                    carrie.Titel = "Carrie";
                    carrie.AutorId = 1;

                    Buch es = new Buch();
                    es.Titel = "Es";
                    es.AutorId = 1;

                    db.Buch.Add(sie);
                    db.Buch.Add(carrie);
                    db.Buch.Add(es);

                    //Bücher Meyer
                    Buch morgen = new Buch();
                    morgen.Titel = "Bis(s) zum Morgengrauen";
                    morgen.AutorId = 2;

                    Buch mittag = new Buch();
                    mittag.Titel = "Bis(s) zur Mittagsstunde";
                    mittag.AutorId = 2;

                    Buch abend = new Buch();
                    abend.Titel = "Bis(s) zum Abendrot";
                    abend.AutorId = 2;

                    db.Buch.Add(morgen);
                    db.Buch.Add(mittag);
                    db.Buch.Add(abend);

                    db.SaveChanges();
                }
                
            }
            //Buch mit index 3 bekommen und den Autor dazu
            using(var db = new BibliothekDb())
            {
                var buch = db.Buch.Include(buch => buch.Autor).FirstOrDefault(buch => buch.BuchID ==3);
                Console.WriteLine($"{buch.Titel}; {buch.Autor.Vorname} {buch.Autor.Name} ");
            }
            //Alle Bücher von Stephenie Meyer bekommen, nach nachem Suchen 
            using(var db = new BibliothekDb())
            {
                var meyer = db.Autor.Where(autor => autor.Name.Contains("Meyer")).Include(autor => autor.Buch).FirstOrDefault();
                Console.WriteLine($"{meyer.Vorname} {meyer.Name}");
                foreach(Buch b in meyer.Buch)
                {
                    Console.WriteLine($"{b.Titel}");
                }
            }
            //Konsole schliesst nicht direkt
            Console.ReadKey();
        }
    }
}
