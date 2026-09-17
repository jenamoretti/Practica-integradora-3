using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_integradora_3
{
    public class Materia : IExportable
    {
        public string codigo;
        public string nombre;
        public int cantidadHoras;

        public Materia(string codigo, string nombre, int cantidadHoras)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.cantidadHoras = cantidadHoras;
        }

        public string ExportarLinea()
        {
            return $"Materia:{codigo};{nombre};{cantidadHoras}";
        }
    }
}
