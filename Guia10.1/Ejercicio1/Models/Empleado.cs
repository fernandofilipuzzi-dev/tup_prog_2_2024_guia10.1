using System;
using System.Collections.Generic;

namespace Ejercicio1.Models
{
    public abstract class Empleado:IComparable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Empleado(int dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }

        abstract public double CalcularImporteAPagar();
        abstract public string[] GenerarRecibo();

        public override string ToString()
        {
            return $"{Nombre}({DNI})";
        }

        public int CompareTo(object obj)
        {
            Empleado otro = obj as Empleado;
            if (otro is Empleado)
            { 
                return this.DNI.CompareTo(otro.DNI);
            }
            return 1; 
        }
    }   
}
