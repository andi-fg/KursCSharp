using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_EF1
{
    class Autor
    {
        [Column("Autor_ID")]
        public int AutorID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [Required]
        public string Vorname { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Geburtsdatum { get; set; }
        public virtual ICollection<Buch> Buch { get; set; }
    }
}
