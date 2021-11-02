using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_EF1
{
    class Buch
    {
        [Column("Buch_ID")]
        public int BuchID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [Required]
        public string Titel { get; set; }

        [Column("Autor_ID")]
        public int AutorId { get; set; }

        public Autor Autor { get; set; }
    }
}
