using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Tecnico : IExportable
    {
        public string CUIT { get; private set; }
        public string Nombre { get; private set; }

        public string Cargo { get; set; }

        public Tecnico()
        {
        }

        public Tecnico(string cuit, string nombre, string cargo)
        {
            CUIT = cuit;
            Nombre = nombre;
            Cargo = cargo;
        }

        public void Leer(string[] linea)
        {
            CUIT = linea[1];
            Nombre = linea[2];
            Cargo = linea[3];
        }

        public string Escribir()
        {
            return $"{CUIT};{Nombre};{Cargo}";
        }
    }
}
