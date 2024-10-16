using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace Ejercicio1.Models
{
    public class Jornalero:Empleado
    {
        public int HorasTrabajadas { get; set; }
        public double ImportePorHora { get; set; }
        public double RetencionesImpositivas { get; set; }

        public Jornalero(int dni, string nombre, int horas, double importePorHora, double retencion) :base(dni,nombre)
        {
            HorasTrabajadas = horas;
            ImportePorHora = importePorHora;
            RetencionesImpositivas = retencion;
        }

        public override double CalcularImporteAPagar()
        {
            return HorasTrabajadas * ImportePorHora - RetencionesImpositivas;
        }

        public override string[] GenerarRecibo()
        {
            List<string> recibo= new List<string>();

            recibo.Add($" El Sr/a {Nombre}({DNI}) recibió la suma de ${CalcularImporteAPagar():f2} ");
            recibo.Add($" En concepto de horas de trabajo: ({HorasTrabajadas}) ");
            recibo.Add($" Siendo el valor de la hora {ImportePorHora} y  ");
            recibo.Add($" a la cual se le ha retenido por conceptos impositivos la suma de:");
            recibo.Add($" ${RetencionesImpositivas}");

            return recibo.ToArray();
        }
    }
}
