using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Policia
    {
        private int dni;
        private string nombre;
        private int nroPlaca;
        public int Dni { get;}
        public string Nombre { get; }
        public int NroPlaca { get; }

        public Policia (int dni, string nombre, int placa)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.NroPlaca = placa;
        }

        public string VerDatos()
        {
            return $"Nombre: {Nombre}, DNI: {Dni}, Nro Placa: {NroPlaca}";
        }
    }
}
