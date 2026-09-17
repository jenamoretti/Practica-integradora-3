using System;

namespace Practica_integradora_3
{
    public class Alumno : Persona
    {
        private double nota1;
        private double nota2;

        public Alumno(string nombre, int legajo) : base(nombre, legajo)
        {
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
            if (nota1 < 10) nota1++;
            if (nota2 < 10) nota2++;
        }

        public bool CargarNotas(double nota1, double nota2)
        {
            if (nota1 <= 10 && nota2 <= 10)
            {
                this.nota1 = nota1;
                this.nota2 = nota2;
                return true;
            }
            return false;
        }
    }
}