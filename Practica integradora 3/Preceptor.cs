using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_integradora_3
{
    public class Preceptor : Persona
    {
        public string turno;

        public Preceptor(string nombre, int documento, string turno) : base(nombre, documento)
        {
            this.turno = turno;
        }

        public override string Presentarse()
        {
            return $"Hola, soy {nombre}, preceptor del turno {turno}.";
        }
    }
}
