using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Guardia
    {

        private int horaHasta;
        private int minutoHasta;
        private int horaDesde;
        private int minutoDesde;
        private int cantidadMinutos;

        public int HoraDesde { get; private set; }
        public int HoraHasta { get; private set; }
        public int MinutoDesde { get; private set; }
        public int MinutoHasta { get; private set; }
        public int CantidadMinutos { get; private set; }
        public Policia policia { get; private set; }

        public Guardia()
        { 

        }
        public void AsignarPolicia(Policia policia, int h, int m, int cantM)
        {
            this.policia = policia;
            this.HoraHasta = h;
            this.MinutoHasta = m;
            this.cantidadMinutos = cantM;
        }


    }
}
