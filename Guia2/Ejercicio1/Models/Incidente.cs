using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Incidente
    {

        public string Motivo;
        public int Hora;
        public int Minuto;
        private int tipoIncidente;
        private Policia policia;
        private Persona persona;

        public Policia Policia { get; private set; }
        public int TipoIncidente { get; private set; }
        public Persona Persona { get; private set; }

        public Incidente(Policia oficial,Persona sujeto,int tipoIncidente)
        {
            this.Policia = oficial;
            this.Persona = sujeto;
            this.TipoIncidente = tipoIncidente;
        }

        public string VerDescripcion()
        {
            return $"Policia: {Policia.VerDatos()}, Persona: {Persona.VerDatos()}, Tipo Incidente: {TipoIncidente}";
        }

        public override string ToString()
        {
            return VerDescripcion();
        }

    }
}
