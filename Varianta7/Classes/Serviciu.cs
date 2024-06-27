using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianta7.Classes
{
    internal class Serviciu
    {
        [Key]
        public int CodServiciu { get; set; }
        public string Denumirea { get; set; }
        [NotMapped]
        private decimal _Pret { get; set; }
        public decimal Pret {
            get => _Pret; 
            set {
                _Pret = (decimal)Math.Round(value, 2);
            }
        }
        public int Durata { get; set; }
    }
}
