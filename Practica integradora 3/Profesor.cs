using System;

namespace Practica_integradora_3
{
    public class Profesor : Persona, IExportable
    {
        public string materia;

        public Profesor(string nombre, int documento, string materia) : base(nombre, documento)
        {
            this.materia = materia;
        }

        public override string Presentarse()
        {
            return $"Hola, soy {nombre} y dicto {materia}.";
        }

        public string ExportarLinea()
        {
            return $"Profesor:{documento};{nombre};{materia}";
        }
    }
}