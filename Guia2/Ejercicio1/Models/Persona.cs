using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Persona
    {

        private int dni;
        private string nombre;
        public int Dni { get; }
        public string Nombre { get; }

        public Persona (int dni, string nombre)
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }

        public string VerDatos()
        {
            return $"Nombre: {Nombre}, DNI: {Dni}";
        }

    }
}
