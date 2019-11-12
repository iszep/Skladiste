using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Skladiste.Models
{
    public class Artikal
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public decimal Kolicina { get; set; }
        public string Jedinica_Mjere { get; set; }
        [NotMapped]
        public decimal Ulaz { get; set; }
        [NotMapped]
        public decimal Izlaz { get; set; }

    }
}
