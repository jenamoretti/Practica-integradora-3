using System;
using System.Collections.Generic;
using System.Text;
using Practica_integradora_3;

namespace Practica_integradora_3
{
    public class Alumno
    {
        public string nombre;
        public int legajo;
        public double nota1;
        public double nota2;

        public Alumno(string nombre, int legajo, double nota1, double nota2)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }
        public float CalcularPromedio()
        {
            return (float)((nota1 + nota2) / 2);
        }

        public bool EstaAprobado()
        {
            return CalcularPromedio() >= 6.0;
        }

        public void SubirNota()
        {
            if (nota1 < 10)
            {
                nota1++;
            }
            if (nota2 < 10)
            {
                nota2++;
            }
        }
    }
}
