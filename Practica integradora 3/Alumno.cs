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
    }
}
