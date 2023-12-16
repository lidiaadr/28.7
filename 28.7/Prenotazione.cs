using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Prenotazione
    {
        public DateTime DataPrenotazione { get; set; }
        public int Anno { get; set; }
        public TimeSpan PeriodoPrenotazione { get; set; }
        public float Caparra { get; set; }
        public float Tariffa { get; set; }  
        public List<Servizio> Servizi { get; set; }
    }
}
