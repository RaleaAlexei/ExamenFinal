using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianta7.Classes
{
    internal class Programari
    {
        [Key]
        public int CodProgramare { get; set; }
        public string NumeClient { get; set; }
        public string Telefon { get; set; }
        public DateTime DataProgramarii { get; set; }
        public TimeSpan OraProgramarii { get; set; }
        [ForeignKey("Serviciu")]
        public int CodServiciu { get; set; }
        public string Mester { get; set; }
        public virtual Serviciu Serviciu { get; set; }
    }
}
