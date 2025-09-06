using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Comisaria
    {
        List<Incidente> incidentes = new List<Incidente>();
        private int cantidadIncidentes;
        private Incidente incidente;
        private Guardia[] guardias=new Guardia[2];
        private Policia agente;

        public int CantidadIncidentes { get; private set; }
        public bool AsignarPolicia(Policia policia)
        {
            if(policia !=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Policia VerAgente(int NroPlaca) 
        {

            if (guardias[0].policia.NroPlaca==NroPlaca)
            {
               return guardias[0].policia;
            }
            if (guardias[1].policia.NroPlaca==NroPlaca)
            {
                return guardias[1].policia;
            }
            else
            {
                return null;
            }

        }

        public void RegistrarIncidente(Policia agente,Persona sujeto,string motivo,int h,int m,int tipoIncidente)
        {

            incidente=new Incidente(agente,sujeto,tipoIncidente);
            incidente.Motivo = motivo;
            incidente.Hora = h;
            incidente.Minuto = m;

            incidentes.Add(incidente);

        }

        public void AsignarGuardia(int h1,int m1,int tiempoMinutos,Policia agente)
        { Guardia g=new Guardia();
            g.AsignarPolicia(agente,h1,m1,tiempoMinutos);
            if(guardias[0]==null)
            {
                guardias[0]=g;
            }
            else if(guardias[1]==null)
            {
                guardias[1]=g;
            }

        }

        public Incidente VerIncidente(int idx)
        {
            if(idx>=0 && idx<incidentes.Count)
            {
                return incidentes[idx];
            }
            else
            {
                return null;
            }
        }
        
    }
}
