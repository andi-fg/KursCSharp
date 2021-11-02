using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_EF1
{
    class BibliothekDb : DbContext
    {
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Buch> Buch { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0JNA88J\SQLEXPRESS;Initial Catalog=Bibliothek;Integrated Security=True;MultipleActiveResultSets=True");
        }
    }
}
