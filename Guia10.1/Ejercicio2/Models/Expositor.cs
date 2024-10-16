
using System;

namespace Ejercicio2.Models
{
    public class Expositor : Persona, IExportable
    {
        public string PapelProtagonico { get; set; }

        public Expositor():base(0,"") //persona no valida
        {
        }

        public Expositor(int dni, string nombre, string papelProtagonico):base(dni,nombre)
        {
            PapelProtagonico = papelProtagonico;
        }

        public void Leer(string[] linea)
        {
            dni = Convert.ToInt32(linea[1]);
            nombre = linea[2];
            PapelProtagonico = linea[3];
        }

        public string Escribir()
        {
            return $"{dni};{nombre};{PapelProtagonico}";
        }
    }
}
