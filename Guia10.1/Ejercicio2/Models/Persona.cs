using System;
using System.Collections.Generic;

namespace Ejercicio2.Models
{
    public abstract class Persona:IComparable
    {
        protected int dni;
        protected string nombre;

        public int DNI { get { return dni; } }
        public string Nombre { get { return nombre; } }

        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

         public override string ToString()
        {
            return $"{Nombre}({DNI})";
        }

        public int CompareTo(object obj)
        {
            Persona otro = obj as Persona;
            if (otro is Persona)
            { 
                return this.DNI.CompareTo(otro.DNI);
            }
            return 1; 
        }
    }   
}
