using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Camera
    {
        public int Numero { get; set; }
        public string Descrizione { get; set; }
        public string TipologiaSingola { get; set; }
        public string TipologiaDoppia { get; set; }
        public List<Prenotazione> Prenotazioni { get; set; }

    }
}
