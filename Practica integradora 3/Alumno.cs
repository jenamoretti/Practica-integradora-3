using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Practica_integradora_3;

namespace Practica_integradora_3
{
    public class Alumno
    {
        public string nombre;
        public int legajo;
        private double nota1;
        private double nota2;

        public Alumno(string nombre, int legajo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
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

        public bool CargarNotas(double nota1, double nota2)
        {
            if(nota1 <= 10 && nota2 <= 10)
            {
                this.nota1 = nota1;
                this.nota2 = nota2;
                return true;
            }
            
            return false;
           
        }

        public override string ToString()
        {
            Console.WriteLine(legajo + " - " + nombre + $" (promedio: {CalcularPromedio()})");
            return base.ToString();
        }
    }
}
