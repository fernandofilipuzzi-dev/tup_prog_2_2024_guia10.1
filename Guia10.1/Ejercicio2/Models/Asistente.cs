
using System;

namespace Ejercicio2.Models
{
    public class Asistente : Persona
    {
        public double ValorSeguro { get; set; }

        
        public Asistente(int dni,String nombre, double valorSeguro):base(dni,nombre)
        {
            ValorSeguro = valorSeguro;
        }
    }
}
